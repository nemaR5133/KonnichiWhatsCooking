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
    //bATTTER RICE VEGIITABLES
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GrillSlot1 == true)
        {
            GrillTimer1 -= Time.deltaTime;
        }
        if (GrillSlot2 == true)
        {
            GrillTimer2 -= Time.deltaTime;
        }
        if (GrillSlot3 == true)
        {
            GrillTimer3 -= Time.deltaTime;
        }

        if (GrillTimer1 == 0)
        {
            foodIsDone1 = true;
        }
        if (GrillTimer2 == 0)
        {
            foodIsDone2 = true;
        }
        if (GrillTimer3 == 0)
        {
            foodIsDone3 = true;
        }
    }
    //Checks if player is on the trigger
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (foodIsDone1 == true)
            {
                if ()
                {

                }
            }
            if (foodIsDone2 == true)
            {

            }
            if (foodIsDone3 == true)
            {

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
                            //If it is Uncooked Rice set to 3
                            else if (PlayerPickUpScript.UncookedRice == true)
                            {
                                GrillSlot1Vaule = 3;
                                GrillSlot1 = true;
                                GrillTimer1 = UncookedRiceTimer;
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
                            //If it is Uncooked Rice set to 3
                            else if (PlayerPickUpScript.UncookedRice == true)
                            {
                                GrillSlot3Vaule = 3;
                                GrillSlot3 = true;
                                GrillTimer3 = UncookedRiceTimer;
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
