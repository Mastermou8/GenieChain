using System;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;

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
    public GenieSystem genieSystem;
    

    string[] messages;
    int messagesIndex = 0;
    bool isActive = false;
    public bool playerSpeaking = false;
    public bool resetTrigger = false;

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

            if(playerSpeaking == true)
            {
                Debug.Log("Showing player name");
                nameText.text = "You";
            }

            if(resetTrigger == true)
            {
                Debug.Log("Showing Genie name");
                nameText.text = "Genie";
            }

            Debug.Log("printing next message part");
            DialogSystem.SetActive(true);
            isActive = true;
            text.text = messages[messagesIndex].Trim();
            messagesIndex++;

            if (wishCarrier.returning == true && wishCarrier.askedWish3 == true && wishCarrier.readyToLeave == false)
            {
                Debug.Log("Setting up player name");
                playerSpeaking = true; 
            }

        }
        else
        {
            Debug.Log("End of message");
            DialogSystem.SetActive(false);
            messagesIndex = 0;
            firstMessagePlayed = true;

            if (!EnsureWishCarrier() || wishCarrier.readyToLeave == false)
            {
                if (!wishCarrier.askedWish3)
                {
                    wishBox.SetActive(true);
                    Debug.Log("turned on wishbox");
                    wishCarrier.readyToLeave = true;
                }
                else
                {
                    Debug.Log("third wish made, finding if need to trigger");
                    if(resetTrigger == false && wishCarrier.returning == true)
                    {
                        Debug.Log("Reached lesson text");
                        genieSystem.message = "You have learned... for that I will give you back what you had. | You are growing.";
                        resetTrigger = true;
                        wishCarrier.readyToLeave = true;
                    }
                }
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

    private void Start()
    {
        GameObject targetObject = GameObject.FindGameObjectWithTag("Log");
        if(targetObject != null)
        {
            WishCarrier wishCarrier = targetObject.GetComponent<WishCarrier>();
        }
    }
}
