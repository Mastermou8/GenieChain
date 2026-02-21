using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.Networking.PlayerConnection;

public class DialogManager : MonoBehaviour
{

    //this is the text object
    public TMP_Text text;
    public GameObject DialogSystem;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ShowMessage("Hello, How are you? | I am a cute Npc named Dawson | I am super gay | Come here I want kiss");
        
    }

    string[] messages;
    int messagesIndex = 0;
    // Update is called once per frame
    public void ShowMessage(string Message)
    {
        messages = Message.Split('|');
        DialogSystem.SetActive(true);
        text.text = messages[messagesIndex];
        Skip();


    }

    public void Skip()
    {
        if(messagesIndex < messages.Length - 1)
        {
            
            text.text = messages[messagesIndex];
            messagesIndex++;
        }
        else
        {
            DialogSystem.SetActive(false);
            messagesIndex = 0;
        }
    }
}
