using TMPro;
using UnityEngine;

public class GenieDialogManager : MonoBehaviour
{
    //this is the text object
    public TMP_Text text;
    public TMP_Text nameText;
    public GameObject DialogSystem;
    public bool firstMessagePlayed = false;
    public bool releasePlayer = true;
    public WishHandler wishHandler;
    public GameObject wishBox;
    public WishCarrier wishCarrier;

    string[] messages;
    int messagesIndex = 0;
    bool isActive = false;

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

    private void Awake()
    {
        EnsureWishCarrier();
    }

    // Update is called once per frame
    public void ShowMessage(string Message)
    {

        messages = Message.Split('|');
        if ((messagesIndex < messages.Length) && (wishBox.active == false))
        {
            
            Debug.Log("printing next message part");
            DialogSystem.SetActive(true);
            isActive = true;
            text.text = messages[messagesIndex].Trim();
            messagesIndex++;
        }
        else
        {
            Debug.Log("End of message");
            DialogSystem.SetActive(false);
            messagesIndex = 0;
            firstMessagePlayed = true;

            if (!EnsureWishCarrier() || wishCarrier.readyToLeave == false)
            {
                wishBox.SetActive(true);
                Debug.Log("turned on wishbox");
            }
        }

    }

    public void Skip()
    {
        if (!isActive)
        {
            return;
        }

        if (messagesIndex < messages.Length)
        {

            text.text = messages[messagesIndex].Trim();
            messagesIndex++;
        }
        else
        {
            DialogSystem.SetActive(false);
            messagesIndex = 0;
            isActive = false;
            firstMessagePlayed = true;
            if (!EnsureWishCarrier() || wishCarrier.readyToLeave == false)
            {
                wishBox.SetActive(true);
                Debug.Log("turned on wishbox");
            }

        }
    }

    private void Update()
    {
        
    }
}
