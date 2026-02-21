using NUnit.Framework;
using UnityEngine;

public class NPCSystem : MonoBehaviour
{

    [SerializeField] private DialogManager dialogManager;
    [TextArea]
    [SerializeField] private string message = "Hello, how are you? | I am a cute NPC named Dawson.";
    [SerializeField] private string message2 = "Hello, how are you? | I am a cute NPC named Dawson.";
    [SerializeField] private string playerTag = "Player";

    private bool playerDetection = false;
    public int npcDialog = 0;
    public GameObject InteractionPrompt;
    public string npcName;

    void Awake()
    {
        if (dialogManager == null)
        {
            dialogManager = FindObjectOfType<DialogManager>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerDetection && Input.GetKeyDown(KeyCode.E))
        {
            if (dialogManager == null)
            {
                Debug.LogWarning("DialogManager reference missing.");
                return;
            }

            Debug.Log("E pressed while in range");
            if (npcDialog == 0)
            {
                dialogManager.nameText.text = npcName;
                dialogManager.ShowMessage(message);
                npcDialog = 1;
            }
            else
            {
                dialogManager.nameText.text = npcName;
                dialogManager.ShowMessage(message2);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(playerTag))
        {
            playerDetection = true;
            InteractionPrompt.SetActive(true);
            Debug.Log("Entered NPC trigger: " + other.name);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag(playerTag))
        {
            InteractionPrompt.SetActive(false);
            playerDetection = false;
        }
    }
}
