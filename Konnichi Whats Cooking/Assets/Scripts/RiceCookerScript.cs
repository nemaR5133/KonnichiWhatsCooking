using UnityEngine;

public class RiceCookerScript : MonoBehaviour
{
    bool RiceIsThere = false;
    bool RiceIsCooked = false;
    public float RiceTimer;


    // Update is called once per frame
    void Update()
    {
        if (RiceIsThere == true)
        {
            RiceTimer -= Time.deltaTime;
        }
        if (RiceTimer <= 0)
        {
            RiceIsCooked = true;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "RiceCooker")
        {
            //When E Is pressed
            if (Input.GetKeyDown(KeyCode.E))
            {
              //If it is Uncooked Rice set to 3
               if (PlayerPickUpScript.UncookedRice == true)
              {
                    RiceIsThere = true;
              }
               if (RiceIsCooked == true)
                {
                    PlayerPickUpScript.UncookedRice = false;
                    PlayerPickUpScript.CookedRice = true;
                }
            }

        }
    }
}
