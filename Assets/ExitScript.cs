using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScript : MonoBehaviour
{
    public WishCarrier wishCarrier;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


    }

 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //tps player to new scene 
        if ((collision.gameObject.CompareTag("Player") == true) && (wishCarrier.readyToLeave == true))
        {
            Debug.Log("detected player");
            wishCarrier.readyToLeave = false;
            SceneManager.LoadScene("CityScene");
        }
    }
}
