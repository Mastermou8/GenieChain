using UnityEngine;



public class WishCarrier : MonoBehaviour
{

    public string wish1;
    public string wish2;
    public string wish3;

    public bool askedWish1 = false;
    public bool askedWish2 = false;
    public bool askedWish3 = false;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
