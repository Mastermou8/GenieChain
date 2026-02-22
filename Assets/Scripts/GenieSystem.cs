using System.Collections.Generic;
using UnityEngine;

public class GenieSystem : MonoBehaviour
{
    [SerializeField] private GenieDialogManager dialogManager;
    [SerializeField] private GeniePlayerController playerController;
    [TextArea]
    [SerializeField] private string message = "Hello, how are you? | I am a cute NPC named Dawson.";

    [Header("Individual Wishes")]
    [SerializeField] private string WorldPeace;
    [SerializeField] private string Money;
    [SerializeField] private string Relationships;
    [SerializeField] private string Accomplished;
    [SerializeField] private string MoreWishes;
    [SerializeField] private string Immortality;
    [SerializeField] private string Nothing;

    [Header("Combinations of 2")]
    [SerializeField] private string WorldPeace_Money;
    [SerializeField] private string WorldPeace_Relationships;
    [SerializeField] private string WorldPeace_Accomplished;
    [SerializeField] private string WorldPeace_MoreWishes;
    [SerializeField] private string WorldPeace_Immortality;
    [SerializeField] private string Money_Relationships;
    [SerializeField] private string Money_Accomplished;
    [SerializeField] private string Money_MoreWishes;
    [SerializeField] private string Money_Immortality;
    [SerializeField] private string Relationships_Accomplished;
    [SerializeField] private string Relationships_MoreWishes;
    [SerializeField] private string Relationships_Immortality;
    [SerializeField] private string Accomplished_MoreWishes;
    [SerializeField] private string Accomplished_Immortality;
    [SerializeField] private string MoreWishes_Immortality;

    [Header("Combinations of 3")]
    [SerializeField] private string WorldPeace_Money_Relationships;
    [SerializeField] private string WorldPeace_Money_Accomplished;
    [SerializeField] private string WorldPeace_Money_MoreWishes;
    [SerializeField] private string WorldPeace_Money_Immortality;
    [SerializeField] private string WorldPeace_Relationships_Accomplished;
    [SerializeField] private string WorldPeace_Relationships_MoreWishes;
    [SerializeField] private string WorldPeace_Relationships_Immortality;
    [SerializeField] private string WorldPeace_Accomplished_MoreWishes;
    [SerializeField] private string WorldPeace_Accomplished_Immortality;
    [SerializeField] private string WorldPeace_MoreWishes_Immortality;
    [SerializeField] private string Money_Relationships_Accomplished;
    [SerializeField] private string Money_Relationships_MoreWishes;
    [SerializeField] private string Money_Relationships_Immortality;
    [SerializeField] private string Money_Accomplished_MoreWishes;
    [SerializeField] private string Money_Accomplished_Immortality;
    [SerializeField] private string Money_MoreWishes_Immortality;
    [SerializeField] private string Relationships_Accomplished_MoreWishes;
    [SerializeField] private string Relationships_Accomplished_Immortality;
    [SerializeField] private string Relationships_MoreWishes_Immortality;
    [SerializeField] private string Accomplished_MoreWishes_Immortality;

    [SerializeField] private string playerTag = "Player";

    private bool playerDetection = false;
    private Dictionary<string, string> dialogueMap;

    public GameObject InteractionPrompt;
    public string npcName;
    public WishCarrier wishCarrier;

    void Awake()
    {
        if (dialogManager == null)
        {
            dialogManager = FindObjectOfType<GenieDialogManager>();

        }
        if (playerController == null)
        {
            playerController = FindObjectOfType<GeniePlayerController>();
        }
        InitializeDialogueMap();
    }

    void InitializeDialogueMap()
    {
        dialogueMap = new Dictionary<string, string>
        {
            // Individual wishes
            { "WorldPeace", WorldPeace },
            { "Money", Money },
            { "Relationships", Relationships },
            { "Accomplished", Accomplished },
            { "MoreWishes", MoreWishes },
            { "Immortality", Immortality },
            { "Nothing", Nothing },
            
            // Combinations of 2 (alphabetically sorted)
            { "Accomplished|Money", Money_Accomplished },
            { "Accomplished|MoreWishes", Accomplished_MoreWishes },
            { "Accomplished|Relationships", Relationships_Accomplished },
            { "Accomplished|WorldPeace", WorldPeace_Accomplished },
            { "Immortality|Money", Money_Immortality },
            { "Immortality|MoreWishes", MoreWishes_Immortality },
            { "Immortality|Relationships", Relationships_Immortality },
            { "Immortality|WorldPeace", WorldPeace_Immortality },
            { "Money|MoreWishes", Money_MoreWishes },
            { "Money|Relationships", Money_Relationships },
            { "Money|WorldPeace", WorldPeace_Money },
            { "MoreWishes|Relationships", Relationships_MoreWishes },
            { "MoreWishes|WorldPeace", WorldPeace_MoreWishes },
            { "Relationships|WorldPeace", WorldPeace_Relationships },
            
            // Combinations of 3 (alphabetically sorted)
            { "Accomplished|Immortality|Money", Money_Accomplished_Immortality },
            { "Accomplished|Immortality|MoreWishes", Accomplished_MoreWishes_Immortality },
            { "Accomplished|Immortality|Relationships", Relationships_Accomplished_Immortality },
            { "Accomplished|Immortality|WorldPeace", WorldPeace_Accomplished_Immortality },
            { "Accomplished|Money|MoreWishes", Money_Accomplished_MoreWishes },
            { "Accomplished|Money|Relationships", Money_Relationships_Accomplished },
            { "Accomplished|Money|WorldPeace", WorldPeace_Money_Accomplished },
            { "Accomplished|MoreWishes|Relationships", Relationships_Accomplished_MoreWishes },
            { "Accomplished|MoreWishes|WorldPeace", WorldPeace_Accomplished_MoreWishes },
            { "Accomplished|Relationships|WorldPeace", WorldPeace_Relationships_Accomplished },
            { "Immortality|Money|MoreWishes", Money_MoreWishes_Immortality },
            { "Immortality|Money|Relationships", Money_Relationships_Immortality },
            { "Immortality|Money|WorldPeace", WorldPeace_Money_Immortality },
            { "Immortality|MoreWishes|Relationships", Relationships_MoreWishes_Immortality },
            { "Immortality|MoreWishes|WorldPeace", WorldPeace_MoreWishes_Immortality },
            { "Immortality|Relationships|WorldPeace", WorldPeace_Relationships_Immortality },
            { "Money|MoreWishes|Relationships", Money_Relationships_MoreWishes },
            { "Money|MoreWishes|WorldPeace", WorldPeace_Money_MoreWishes },
            { "Money|Relationships|WorldPeace", WorldPeace_Money_Relationships },
            { "MoreWishes|Relationships|WorldPeace", WorldPeace_Relationships_MoreWishes },
        };
    }

    // Update is called once per frame
    void Update()
    {

        if(wishCarrier.readyToLeave == true)
        {
            message = "Go, enjoy your wish | Come back later for your next.";
        }



        if (playerDetection && Input.GetKeyDown(KeyCode.E))
        {
            if (dialogManager == null)
            {
                Debug.LogWarning("DialogManager reference missing.");
                return;
            }

            Debug.Log("E pressed while in range");
            dialogManager.nameText.text = npcName;
            playerController.allowMovement = false;

            string dialogueKey = GetDialogueKey();
            string dialogue = GetDialogue(dialogueKey);

            if (dialogue != null)
            {

                Debug.Log("Detected there is a diologue");
                if(wishCarrier.returning == true)
                {
                    dialogManager.releasePlayer = false;
                    dialogManager.ShowMessage(dialogue);

                    //stops character while talking
                    playerController.currentVel.x = 0;
                    playerController.currentVel.y = 0;
                }
            }
            else
            {
                dialogManager.releasePlayer = false;
                dialogManager.ShowMessage(message);

                //stops character while talking
                playerController.currentVel.x = 0;
                playerController.currentVel.y = 0;
            }
        }



        if ((dialogManager.releasePlayer == true) && (playerController.allowMovement == false))
        {
            playerController.allowMovement = true;
        }


        
    }

    string GetDialogueKey()
    {
        if (!string.IsNullOrEmpty(wishCarrier.wish3))
        {
            string[] wishes = { wishCarrier.wish1, wishCarrier.wish2, wishCarrier.wish3 };
            System.Array.Sort(wishes);
            return $"{wishes[0]}|{wishes[1]}|{wishes[2]}";
        }
        else if (!string.IsNullOrEmpty(wishCarrier.wish2))
        {
            string[] wishes = { wishCarrier.wish1, wishCarrier.wish2 };
            System.Array.Sort(wishes);
            return $"{wishes[0]}|{wishes[1]}";
        }
        else if (!string.IsNullOrEmpty(wishCarrier.wish1))
        {
            return wishCarrier.wish1;
        }
        return null;
    }

    string GetDialogue(string key)
    {
        if (key != null && dialogueMap.TryGetValue(key, out string dialogue))
        {
            return dialogue;
        }
        return null;
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
