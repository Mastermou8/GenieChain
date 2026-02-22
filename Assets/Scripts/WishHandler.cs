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

        if(wishCarrier.askedWish1 == false)
        {
            wishCarrier.wish1 = "Money";
            wishCarrier.askedWish1 = true;
        }
        else if(wishCarrier.askedWish2 == false)
        {
            wishCarrier.wish2 = "Money";
            wishCarrier.askedWish2 = true;
        }
        else if (wishCarrier.askedWish3 == false)
        {
            wishCarrier.wish3 = "Money";
            wishCarrier.askedWish3 = true;
        }
        
        wishBox.SetActive(false);
        wishCarrier.readyToLeave = true;
        dialogManager.releasePlayer = true;
        
    }

    public void Relationship()
    {
        Debug.Log("Relationships picked!");

        if (wishCarrier.askedWish1 == false)
        {
            wishCarrier.wish1 = "Relationships";
            wishCarrier.askedWish1 = true;
        }
        else if (wishCarrier.askedWish2 == false)
        {
            wishCarrier.wish2 = "Relationships";
            wishCarrier.askedWish2 = true;
        }
        else if (wishCarrier.askedWish3 == false)
        {
            wishCarrier.wish3 = "Relationships";
            wishCarrier.askedWish3 = true;
        }

        wishBox.SetActive(false);
        wishCarrier.readyToLeave = true;
        dialogManager.releasePlayer = true;
    }

    public void WorldPeace()
    {
        Debug.Log("WorldPeace Picked");

        if (wishCarrier.askedWish1 == false)
        {
            wishCarrier.wish1 = "WorldPeace";
            wishCarrier.askedWish1 = true;
        }
        else if (wishCarrier.askedWish2 == false)
        {
            wishCarrier.wish2 = "WorldPeace";
            wishCarrier.askedWish2 = true;
        }
        else if (wishCarrier.askedWish3 == false)
        {
            wishCarrier.wish3 = "WorldPeace";
            wishCarrier.askedWish3 = true;
        }

        wishBox.SetActive(false);
        wishCarrier.readyToLeave = true;
        dialogManager.releasePlayer = true;
    }

    public void MoreWishes()
    {
        Debug.Log("More Wishes picked!");

        if (wishCarrier.askedWish1 == false)
        {
            wishCarrier.wish1 = "MoreWishes";
            wishCarrier.askedWish1 = true;
        }
        else if (wishCarrier.askedWish2 == false)
        {
            wishCarrier.wish2 = "MoreWishes";
            wishCarrier.askedWish2 = true;
        }
        else if (wishCarrier.askedWish3 == false)
        {
            wishCarrier.wish3 = "MoreWishes";
            wishCarrier.askedWish3 = true;
        }

        wishBox.SetActive(false);
        wishCarrier.readyToLeave = true;
        dialogManager.releasePlayer = true;
    }

    public void Accomplished()
    {
        Debug.Log("Accomplished picked!");

        if (wishCarrier.askedWish1 == false)
        {
            wishCarrier.wish1 = "Accomplished";
            wishCarrier.askedWish1 = true;
        }
        else if (wishCarrier.askedWish2 == false)
        {
            wishCarrier.wish2 = "Accomplished";
            wishCarrier.askedWish2 = true;
        }
        else if (wishCarrier.askedWish3 == false)
        {
            wishCarrier.wish3 = "Accomplished";
            wishCarrier.askedWish3 = true;
        }

        wishBox.SetActive(false);
        wishCarrier.readyToLeave = true;
        dialogManager.releasePlayer = true;
    }

    
    public void Immortality()
    {
        Debug.Log("Immortality picked!");

        if (wishCarrier.askedWish1 == false)
        {
            wishCarrier.wish1 = "Immortality";
            wishCarrier.askedWish1 = true;
        }
        else if (wishCarrier.askedWish2 == false)
        {
            wishCarrier.wish2 = "Immortality";
            wishCarrier.askedWish2 = true;
        }
        else if (wishCarrier.askedWish3 == false)
        {
            wishCarrier.wish3 = "Immortality";
            wishCarrier.askedWish3 = true;
        }

        wishBox.SetActive(false);
        wishCarrier.readyToLeave = true;
        dialogManager.releasePlayer = true;
    }

    public void Nothing()
    {
        Debug.Log("Nothing picked!");

        if (wishCarrier.askedWish1 == false)
        {
            wishCarrier.wish1 = "Nothing";
            wishCarrier.askedWish1 = true;
        }
        else if (wishCarrier.askedWish2 == false)
        {
            wishCarrier.wish2 = "Nothing";
            wishCarrier.askedWish2 = true;
        }
        else if (wishCarrier.askedWish3 == false)
        {
            wishCarrier.wish3 = "Nothing";
            wishCarrier.askedWish3 = true;
        }

        wishBox.SetActive(false);
        wishCarrier.readyToLeave = true;
        dialogManager.releasePlayer = true;
    }
}
