using Unity.VisualScripting;
using UnityEngine;



public class WishCarrier : MonoBehaviour
{

    public string wish1;
    public string wish2;
    public string wish3;

    public bool askedWish1 = false;
    public bool askedWish2 = false;
    public bool askedWish3 = false;
    public bool readyToLeave = false;


    //used to see if choosing a wish or recieving feedback from a wish
    public bool returning = false;

    public GameObject money;
    public GameObject relationship;
    public GameObject morewishes;
    public GameObject immortal;
    public GameObject nothing;
    public GameObject worldpeace;
    public GameObject accomplished;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        //disables buttons for already chosen wishes
        if ((wish1 == "Money") || (wish2 == "Money") || (wish3 == "Money"))
        {
            money.SetActive(false);
        }
        if ((wish1 == "Relationships") || (wish2 == "Relationships") || (wish3 == "Relationships"))
        {
            relationship.SetActive(false);
        }
        if ((wish1 == "MoreWishes") || (wish2 == "MoreWishes") || (wish3 == "MoreWishes"))
        {
            morewishes.SetActive(false);
        }
        if ((wish1 == "Immortality") || (wish2 == "Immortality") || (wish3 == "Immortality"))
        {
            immortal.SetActive(false);
        }
        if ((wish1 == "Accomplished") || (wish2 == "Accomplished") || (wish3 == "Accomplished"))
        {
            accomplished.SetActive(false);
        }
        if ((wish1 == "WorldPeace") || (wish2 == "WorldPeace") || (wish3 == "WorldPeace"))
        {
            worldpeace.SetActive(false);
        }
        if ((wish1 == "Nothing") || (wish2 == "Nothing") || (wish3 == "Nothing"))
        {
            nothing.SetActive(false);
        }


    }

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
