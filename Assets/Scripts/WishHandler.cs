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

        if (wishCarrier == null)
        {
            Debug.LogWarning("WishHandler could not find WishCarrier.");
            return false;
        }

        return true;
    }

    private bool HasWish(string wish)
    {
        return wishCarrier.wish1 == wish || wishCarrier.wish2 == wish || wishCarrier.wish3 == wish;
    }

    private void RefreshWishButtons()
    {
        if (!EnsureWishCarrier())
        {
            return;
        }

        if (money != null)
        {
            money.SetActive(!HasWish("Money"));
        }

        if (relationship != null)
        {
            relationship.SetActive(!HasWish("Relationships"));
        }

        if (morewishes != null)
        {
            morewishes.SetActive(!HasWish("MoreWishes"));
        }

        if (immortal != null)
        {
            immortal.SetActive(!HasWish("Immortality"));
        }

        if (accomplished != null)
        {
            accomplished.SetActive(!HasWish("Accomplished"));
        }

        if (worldpeace != null)
        {
            worldpeace.SetActive(!HasWish("WorldPeace"));
        }

        if (nothing != null)
        {
            nothing.SetActive(!HasWish("Nothing"));
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EnsureWishCarrier();
        RefreshWishButtons();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Money()
    {
        if (!EnsureWishCarrier())
        {
            return;
        }

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
        RefreshWishButtons();
        
    }

    public void Relationship()
    {
        if (!EnsureWishCarrier())
        {
            return;
        }

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
        RefreshWishButtons();
    }

    public void WorldPeace()
    {
        if (!EnsureWishCarrier())
        {
            return;
        }

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
        RefreshWishButtons();
    }

    public void MoreWishes()
    {
        if (!EnsureWishCarrier())
        {
            return;
        }

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
        RefreshWishButtons();
    }

    public void Accomplished()
    {
        if (!EnsureWishCarrier())
        {
            return;
        }

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
        RefreshWishButtons();
    }

    
    public void Immortality()
    {
        if (!EnsureWishCarrier())
        {
            return;
        }

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
        RefreshWishButtons();
    }

    public void Nothing()
    {
        if (!EnsureWishCarrier())
        {
            return;
        }

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
        RefreshWishButtons();
    }
}
