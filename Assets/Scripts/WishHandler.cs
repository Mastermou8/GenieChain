using UnityEngine;
using UnityEngine.UI;

public class WishHandler : MonoBehaviour
{
    public GameObject wishBox;
    public GenieDialogManager dialogManager;
    public GameObject money;
    public GameObject relationship;
    public GameObject morewishes;
    public GameObject immortal;
    public GameObject nothing;
    public GameObject worldpeace;
    public GameObject accomplished;
    public WishCarrier wishCarrier;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Money()
    {
        Debug.Log("Money picked!");
        wishCarrier.wish1 = "Money";
        wishCarrier.askedWish1 = true;
        wishBox.SetActive(false);
        wishCarrier.readyToLeave = true;
        dialogManager.releasePlayer = true;
        
    }

    public void Relationship()
    {
        Debug.Log("Relationships picked!");
        wishCarrier.wish1 = "Relationships";
        wishCarrier.askedWish1 = true;
        wishBox.SetActive(false);
        wishCarrier.readyToLeave = true;
        dialogManager.releasePlayer = true;
    }

    public void WorldPeace()
    {
        Debug.Log("WorldPeace picked!");
        wishCarrier.wish1 = "WorldPeace";
        wishCarrier.askedWish1 = true;
        wishBox.SetActive(false);
        wishCarrier.readyToLeave = true;
        dialogManager.releasePlayer = true;
    }

    public void MoreWishes()
    {
        Debug.Log("MoreWishes picked!");
        wishCarrier.wish1 = "MoreWishes";
        wishCarrier.askedWish1 = true;
        wishBox.SetActive(false);
        wishCarrier.readyToLeave = true;
        dialogManager.releasePlayer = true;
    }

    public void Accomplished()
    {
        Debug.Log("Accomplished picked!");
        wishCarrier.wish1 = "Accomplished";
        wishCarrier.askedWish1 = true;
        wishBox.SetActive(false);
        wishCarrier.readyToLeave = true;
        dialogManager.releasePlayer = true;
    }

    
    public void Immortality()
    {
        Debug.Log("Immortality picked!");
        wishCarrier.wish1 = "Immortality";
        wishCarrier.askedWish1 = true;
        wishBox.SetActive(false);
        wishCarrier.readyToLeave = true;
        dialogManager.releasePlayer = true;
    }

    public void Nothing()
    {
        Debug.Log("'Nothing' picked!");
        wishCarrier.wish1 = "Nothing";
        wishCarrier.askedWish1 = true;
        wishBox.SetActive(false);
        wishCarrier.readyToLeave = true;
        dialogManager.releasePlayer = true;
    }
}
