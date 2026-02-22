using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScript : MonoBehaviour
{
    public WishCarrier wishCarrier;

    private bool EnsureWishCarrier()
    {
        if (wishCarrier == null)
        {
            wishCarrier = WishCarrier.Instance;
        }

        if (wishCarrier == null)
        {
            wishCarrier = FindObjectOfType<WishCarrier>();
        }

        return wishCarrier != null;
    }

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EnsureWishCarrier();
    }

    // Update is called once per frame
    void Update()
    {
        


    }

 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!EnsureWishCarrier())
        {
            return;
        }

        //tps player to new scene 
        if ((collision.gameObject.CompareTag("Player") == true) && (wishCarrier.readyToLeave == true))
        {
            Debug.Log("detected player");
            wishCarrier.readyToLeave = false;
            wishCarrier.returning = true;
            SceneManager.LoadScene("CityScene");
        }

       
    }
}
