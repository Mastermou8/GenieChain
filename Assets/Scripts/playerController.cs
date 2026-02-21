using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
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
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
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
        playerRb.AddForce((velDiff/2) * accel, ForceMode2D.Force);

        /* for reference from last project:
        previousVelocity = rb.linearVelocity;
        rb.linearVelocity = ((((direction * movementSpeed)) + previousVelocity) / 2);
        */

    }
}