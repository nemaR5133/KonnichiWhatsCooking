using UnityEngine;

public class GrillStorageScript : MonoBehaviour
{
    bool GrillSlot1;
    bool GrillSlot2;
    bool GrillSlot3;
    bool foodIsDone1;
    bool foodIsDone2;
    bool foodIsDone3;
    int GrillSlot1Vaule;
    int GrillSlot2Vaule;
    int GrillSlot3Vaule;
    float GrillTimer1;
    float GrillTimer2;
    float GrillTimer3;
    public float BatterTimer;
    public float EggTimer;
    public float UncookedRiceTimer;
    public float Vegitible;
    bool OkonomiyakiIsCooking1 = false;
    bool OkonomiyakiIsCooking2 = false;
    bool OkonomiyakiIsCooking3 = false;
    //bATTTER RICE VEGIITABLES

    // Update is called once per frame
    void Update()
    {
        //All the timers for the grill slots
        if (GrillSlot1 == true)
        {
            //Subtracts from the vaule by delta time
            GrillTimer1 -= Time.deltaTime;
        }
        if (GrillSlot2 == true)
        {
            //Subtracts from the vaule by delta time
            GrillTimer2 -= Time.deltaTime;
        }
        if (GrillSlot3 == true)
        {
            //Subtracts from the vaule by delta time
            GrillTimer3 -= Time.deltaTime;
        }
        //When the Grill timer is zero
        if (GrillTimer1 == 0)
        {
            //The food timer in grill slot 1 is done.
            foodIsDone1 = true;
        }
        if (GrillTimer2 == 0)
        {
            //The food timer in grill slot 2 is done.
            foodIsDone2 = true;
        }
        if (GrillTimer3 == 0)
        {
            //The food timer in grill slot 3 is done.
            foodIsDone3 = true;
        }
    }
    //Checks if player is on the trigger
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Grill")
        {
    //When E Is pressed
            if (Input.GetKeyDown(KeyCode.E))
            {
                //if ()
                //Check if food in slot 1 is done
                if (foodIsDone1 == true)

                //Check if food in slot 1 is done
                if (foodIsDone1 == true)
                {
                    if(OkonomiyakiIsCooking1 == false)
                    {
                     if (GrillSlot1Vaule == 1)
                      {
                       PlayerPickUpScript.Pankeeki = true;
                       }
                    }
                    if (OkonomiyakiIsCooking1 == true)
                    {
                    //If it is batter
                    if (GrillSlot1Vaule == 1 && GrillSlot2Vaule == 4 || (GrillSlot1Vaule == 1 && GrillSlot3Vaule == 4))
                    {
                        PlayerPickUpScript.Okonomiyaki = true;
                    }
                    }
                }

                //Check if food in slot 1 is done
                if (foodIsDone2 == true)
                {
                    if (OkonomiyakiIsCooking2 == false)
                    {
                        if (GrillSlot2Vaule == 1)
                        {
                            PlayerPickUpScript.Pankeeki = true;
                        }
                    }
                    if (OkonomiyakiIsCooking2 == true)
                    {
                        //If it is batter
                        if (GrillSlot2Vaule == 1 && GrillSlot1Vaule == 4 || (GrillSlot2Vaule == 1 && GrillSlot3Vaule == 4))
                        {
                            PlayerPickUpScript.Okonomiyaki = true;
                        }
                    }
                }
                //Check if the timer is done to put in Vegis

                if (foodIsDone2 == false && PlayerPickUpScript.Vegitible == true)
                {
                    OkonomiyakiIsCooking2 = true;
                }

                //Check if food in slot 1 is done
                if (foodIsDone3 == true)
                {
                    if (OkonomiyakiIsCooking3 == false)
                    {
                        if (GrillSlot3Vaule == 1)
                        {
                            PlayerPickUpScript.Pankeeki = true;
                        }
                    }
                    if (OkonomiyakiIsCooking3 == true)
                    {
                        //If it is batter
                        if (GrillSlot3Vaule == 1 && GrillSlot1Vaule == 4 || (GrillSlot3Vaule == 1 && GrillSlot2Vaule == 4))
                        {
                            PlayerPickUpScript.Okonomiyaki = true;
                        }
                    }
                }
                //Check if the timer is done to put in Vegis
                if (foodIsDone2 == false && PlayerPickUpScript.Vegitible == true)
                {
                    OkonomiyakiIsCooking2 = true;
                }
                //Cooking eggs 
                if (GrillSlot1Vaule == 2)
                {
                    PlayerPickUpScript.EggIsCooked = true;
                }

                if (GrillSlot2Vaule == 2)
                {
                    PlayerPickUpScript.EggIsCooked = true;
                }

                if (GrillSlot3Vaule == 2)
                {
                    PlayerPickUpScript.EggIsCooked = true;
                }

            }

                if (collision.tag == "Grill")
            {
    //Checks if player is holding item
            if (PlayerPickUpScript.IsHoldingItem == true)
            {
                //Checks if player presses E
            if (Input.GetKeyDown(KeyCode.E))
                    {
                    //If this grill slot is false
                        if( GrillSlot1 == false)
                        {
                            //If the player is holding an item
                            if (PlayerPickUpScript.IsHoldingItem == true)
                            {
                            //If it is batter set to 1
                                if (PlayerPickUpScript.Batter == true)
                                {
                                    GrillSlot1Vaule = 1;
                                    GrillSlot1 = true;
                                    GrillTimer1 = BatterTimer;
                                    foodIsDone1 = false;
                                }
                                //If it is egg set to 2
                                 else if (PlayerPickUpScript.Egg == true)
                                 {
                                    GrillSlot1Vaule = 2;
                                    GrillSlot1 = true;
                                    GrillTimer1 = EggTimer;
                                    foodIsDone1 = false;
                                }

                            //If it is Uncooked Rice set to 4
                            else if (PlayerPickUpScript.Vegitible == true)
                                {
                                    GrillSlot1Vaule = 4;
                                    GrillSlot1 = true;
                                    GrillTimer1 = Vegitible;
                                    foodIsDone1 = false;
                                }
                            }
                        }
                        //If this grill slot is false
                        else if ( GrillSlot2 == false)
                        {
                        //If the player is holding an item
                        if (PlayerPickUpScript.IsHoldingItem == true)
                            {
                            //If it is batter set to 1
                                if (PlayerPickUpScript.Batter == true)
                                {
                                    GrillSlot2Vaule = 1;
                                    GrillSlot2 = true;
                                    GrillTimer2 = BatterTimer;
                                    foodIsDone2 = false;
                                }
                                //If it is egg set to 2
                                else if (PlayerPickUpScript.Egg == true)
                                    {
                                    GrillSlot2Vaule = 2;
                                    GrillSlot2 = true;
                                    GrillTimer2 = EggTimer;
                                    foodIsDone2 = false;
                                }
                                //If it is Uncooked Rice set to 3
                                else if (PlayerPickUpScript.UncookedRice == true)
                                    {
                                        GrillSlot2Vaule = 3;
                                        GrillSlot2 = true;
                                         GrillTimer2 = UncookedRiceTimer;
                                        foodIsDone2 = false;
                                }
                            //If it is Uncooked Rice set to 4
                            else if (PlayerPickUpScript.Vegitible == true)
                                {
                                    GrillSlot2Vaule = 4;
                                    GrillSlot2 = true;
                                    GrillTimer2 = Vegitible;
                                    foodIsDone2 = false;
                                }
                            }
                        }
                        //If this grill slot is false
                        else if (GrillSlot3 == false)
                        {
                        {
                            //If the player is holding an item
                            if (PlayerPickUpScript.IsHoldingItem == true)
                            {
                                //If it is batter set to 1
                                if (PlayerPickUpScript.Batter == true)
                                {
                                    GrillSlot3Vaule = 1;
                                    GrillSlot3 = true;
                                    GrillTimer3 = BatterTimer;
                                    foodIsDone3 = false;
                                    }
                                //If it is egg set to 2
                                else if (PlayerPickUpScript.Egg == true)
                                {
                                    GrillSlot3Vaule = 2;
                                    GrillSlot3 = true;
                                    GrillTimer3 = EggTimer;
                                    foodIsDone3 = false;
                                    }
    
                                //If it is Uncooked Rice set to 4
                                else if (PlayerPickUpScript.Vegitible == true)
                                {
                                    GrillSlot3Vaule = 4;
                                        GrillSlot3 = true;
                                        GrillTimer3 = Vegitible;
                                        foodIsDone3 = false;
                                    }
                            }
                        }
                    }
                    }
                }
        }
        }
        }
  
}
