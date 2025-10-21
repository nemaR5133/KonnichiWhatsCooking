using UnityEngine;
using UnityEngine.UI;
public class WaitressScript : MonoBehaviour
{
    //Game object of the waitress positon
    public GameObject WaitressPos;
    //The waitress
    public GameObject Waitress;
    //The clone of the waitress so that waitress can be destroyed
    public GameObject WaitressClone;
    public GameObject WaitressOrderCollider;    
    public GameObject WaitressOrderColliderClone;
    public GameObject WaitressOrderColliderPos;
    //UI of the dish 1
    public Image DishImage1;
    public Image DishImage2;
    public Image DishImage3;
    //The timer is not on
    bool StartTimer = false;
    //This is the waitress timer
    public float WatriessTimer = 20;
    //The orignal timer vaule that will be saved later
    float OrignalTimerVaule;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float OrderNumber = 1;
    //The timer for how long you have to cook it 
    public float TimerToCook = 100;
    bool TimerToCookStart = false;
    float OgTimerToCookVaule;
    void Start()
    {
        OgTimerToCookVaule = TimerToCook;
        //Turns off ui element for icon
        DishImage1.gameObject.SetActive(false);
        DishImage2.gameObject.SetActive(false);
        DishImage3.gameObject.SetActive(false);
        WaitressAppersToGiveOrder();
    }

    // Update is called once per frame
    void Update()
    {
        //IF Start timer is true
        if (StartTimer == true)
        {
            //This will subtract for the timer
            WatriessTimer -= Time.deltaTime;
        }
        //When it is zero then reset timer and turn it off
        if (WatriessTimer <= 0)
        {
            StartTimer = false;
            WatriessTimer = OrignalTimerVaule;
            //Destroys Waitress
            Destroy(WaitressClone);
            //Turns of Ui
            DishImage1.gameObject.SetActive(false);
        }
        if ( StartTimer == true)
        {
            Destroy(WaitressClone);
        }
        if (TimerToCookStart == true)
        {
            TimerToCook -= Time.deltaTime;
        }
        if (TimerToCook <= 0)
        {
            TimerToCook = OgTimerToCookVaule;
        }

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Bell")
        {
            if (Input.GetKey(KeyCode.E))
            {
                WaitressBell();
            }

        }
        if (collision.tag == "WaitressOrderCollider")
        {
            if (Input.GetKey(KeyCode.E))
            {
                if (PlayerPickUpScript.Okonomiyaki == true)
                {

                }

            }
        }
    }
    void WaitressAppersToGiveOrder()
    {
        if (OrderNumber >= 3)
        {
        //Saves orignal vaule of timer
        OrignalTimerVaule = WatriessTimer;

        //Sets position of waitress clone
        WaitressClone.transform.position = WaitressPos.transform.position;
        //Creates waitress
        WaitressClone = Instantiate(Waitress);
        //Turns on Icon UI element.
        if (OrderNumber == 1)
        {
        DishImage1.gameObject.SetActive(true);
        }
        else if (OrderNumber == 2)
        {
        DishImage2.gameObject.SetActive(true);
        }
        else if (OrderNumber == 2)
        {
        DishImage2.gameObject.SetActive(true);
        }
        //Starts timer
        StartTimer = true;
        OrderNumber += 1;
        }
        }
         void WaitressBell()
         {
            WaitressClone.transform.position = WaitressPos.transform.position;
            WaitressClone = Instantiate(Waitress);

            WaitressOrderColliderClone.transform.position = WaitressOrderColliderPos.transform.position;
            WaitressOrderColliderClone = Instantiate(WaitressOrderCollider);
         }
       
}
