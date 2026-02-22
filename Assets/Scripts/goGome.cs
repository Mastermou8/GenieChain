using UnityEngine;
using UnityEngine.SceneManagement;

public class goGome : MonoBehaviour
{
    // Start is called once be
    // fore the first execution of Update after the MonoBehaviour is created
    [SerializeField] private string playerTag = "Player";
    private bool playerDetection = false;
    public GameObject InteractionPrompt;
    public GameObject InteractionPrompt2;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerDetection && Input.GetKeyDown(KeyCode.E))
        {
             Debug.Log("detected player");
            
            SceneManager.LoadScene("SampleScene");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(playerTag))
        {
            playerDetection = true;
            InteractionPrompt.SetActive(true);
            InteractionPrompt2.SetActive(true);
            Debug.Log("Entered NPC trigger: " + other.name);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag(playerTag))
        {
            InteractionPrompt.SetActive(false);
            InteractionPrompt2.SetActive(false);    
            playerDetection = false;
        }
    }
}
