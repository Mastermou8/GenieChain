using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.Networking.PlayerConnection;

public class DialogManager : MonoBehaviour
{

    //this is the text object
    public TMP_Text text;
    public TMP_Text nameText;
    public GameObject DialogSystem;

    string[] messages;
    int messagesIndex = 0;
    bool isActive = false;
    // Update is called once per frame
    public void ShowMessage(string Message)
    {
        messages = Message.Split('|');
        DialogSystem.SetActive(true);
        messagesIndex = 0;
        isActive = true;
        text.text = messages[messagesIndex].Trim();
        messagesIndex = 1;


    }

    public void Skip()
    {
        if (!isActive)
        {
            return;
        }

        if(messagesIndex < messages.Length)
        {
            
            text.text = messages[messagesIndex].Trim();
            messagesIndex++;
        }
        else
        {
            DialogSystem.SetActive(false);
            messagesIndex = 0;
            isActive = false;
        }
    }
}
