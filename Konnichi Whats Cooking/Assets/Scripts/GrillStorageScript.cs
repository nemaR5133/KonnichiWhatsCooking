using UnityEngine;

public class GrillStorageScript : MonoBehaviour
{
    bool GrillSlot1;
    bool GrillSlot2;
    bool GrillSlot3;
    int GrillSlot1Vaule;
    int GrillSlot2Vaule;
    int GrillSlot3Vaule;
    //bATTTER RICE VEGIITABLES
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Checks if player is on the trigger
    private void OnTriggerStay2D(Collider2D collision)
    {

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
                            }
                            //If it is egg set to 2
                             else if (PlayerPickUpScript.Egg == true)
                             {
                                GrillSlot1Vaule = 2;
                                GrillSlot1 = true;
                            }
                            //If it is Uncooked Rice set to 3
                            else if (PlayerPickUpScript.UncookedRice == true)
                            {
                                GrillSlot1Vaule = 3;
                                GrillSlot1 = true;
                            }
                        //If it is Uncooked Rice set to 4
                        else if (PlayerPickUpScript.Vegitible == true)
                            {
                                GrillSlot1Vaule = 4;
                                GrillSlot1 = true;
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
                            }
                            //If it is egg set to 2
                            else if (PlayerPickUpScript.Egg == true)
                                {
                                GrillSlot2Vaule = 2;
                                GrillSlot2 = true;
                                }
                            //If it is Uncooked Rice set to 3
                            else if (PlayerPickUpScript.UncookedRice == true)
                                {
                                    GrillSlot2Vaule = 3;
                                    GrillSlot2 = true;
                                }
                        //If it is Uncooked Rice set to 4
                        else if (PlayerPickUpScript.Vegitible == true)
                            {
                                GrillSlot2Vaule = 4;
                                GrillSlot2 = true;
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
                            }
                            //If it is egg set to 2
                            else if (PlayerPickUpScript.Egg == true)
                            {
                                GrillSlot3Vaule = 2;
                                GrillSlot3 = true;
                            }
                            //If it is Uncooked Rice set to 3
                            else if (PlayerPickUpScript.UncookedRice == true)
                            {
                                GrillSlot3Vaule = 3;
                                GrillSlot3 = true;
                            }
                            //If it is Uncooked Rice set to 4
                            else if (PlayerPickUpScript.Vegitible == true)
                            {
                                GrillSlot3Vaule = 4;
                                    GrillSlot3 = true;
                                }
                        }
                    }
                }
                }
            }
        }
        }


        
        
}
