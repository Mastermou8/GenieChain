using UnityEngine;

public class GeniePlayerController : MonoBehaviour
{
    private Vector2 moveInput;
    public Rigidbody2D playerRb;
    public float moveSpeed;
    public Vector2 currentVel;
    public Vector2 normVel;
    public Vector2 prevVel;
    public Vector2 targetVel;
    public Vector2 velDiff;
    public float accel;

    public string wish1;
    public string wish2;
    public string wish3;
    [SerializeField] private Animator animator;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private int style;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    private void flipSprite()
    {
        if (moveInput.x < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (moveInput.x > 0)
        {
            spriteRenderer.flipX = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        flipSprite();
        //Collect input
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        //calculate movement speed on either axis
        currentVel.x = moveInput.x * moveSpeed;
        currentVel.y = moveInput.y * moveSpeed;

        //normalize (so player moves same speed diagonally)
        targetVel = currentVel.normalized * moveSpeed;

        //Momentum for the bee (factors in previous velocity)
        prevVel = playerRb.linearVelocity;
        velDiff = targetVel - playerRb.linearVelocity;
        playerRb.AddForce((velDiff / 2) * accel, ForceMode2D.Force);

        if (moveInput != Vector2.zero)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }


        if (Input.GetKeyDown(KeyCode.Q))
        {
            style = (style + 1) % 4;

        }
        animator.SetInteger("Style", style);


        /* for reference from last project:
        previousVelocity = rb.linearVelocity;
        rb.linearVelocity = ((((direction * movementSpeed)) + previousVelocity) / 2);
        */
        if (moveInput == Vector2.zero)
        {
            currentVel.x = 0;
            currentVel.y = 0;
        }

    }
}
