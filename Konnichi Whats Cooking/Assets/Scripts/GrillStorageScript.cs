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
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (PlayerPickUpScript.IsHoldingItem == true)
        {
        if (Input.GetKeyDown(KeyCode.E))
                {
                    if( GrillSlot1 == false)
                    {
                        if (PlayerPickUpScript.IsHoldingItem == true)
                        {
                            if (PlayerPickUpScript.Batter == true)
                            {
                                GrillSlot1Vaule = 1;
                            }
                            else if (PlayerPickUpScript.Egg == true)
                            {
                                GrillSlot1Vaule = 2;
                        }
                            else if (PlayerPickUpScript.UncookedRice == true)
                            {
                                GrillSlot1Vaule = 3;
                                //PlayerPickUpScript.CookedRice = true;
                        }
                            else if (PlayerPickUpScript.Vegitible == true)
                            {
                                GrillSlot1Vaule = 4;
                            }
                        }
                    }
                    else if ( GrillSlot2 == false)
                    {

                    if (PlayerPickUpScript.IsHoldingItem == true)
                        {
                            if (PlayerPickUpScript.Batter == true)
                            {
                                GrillSlot2Vaule = 1;
                            }
                            else if (PlayerPickUpScript.Egg == true)
                            {
                                GrillSlot2Vaule = 2;
                        }
                            else if (PlayerPickUpScript.UncookedRice == true)
                            {
                                GrillSlot2Vaule = 3;
                                //PlayerPickUpScript.CookedRice = true;
                        }
                            else if (PlayerPickUpScript.Vegitible == true)
                            {
                                GrillSlot2Vaule = 4;
                            }
                        }
                    }
                    else if (GrillSlot3 == false)
                    {
                    {
                        if (PlayerPickUpScript.Batter == true)
                        {
                            GrillSlot3Vaule = 1;
                        }
                        else if (PlayerPickUpScript.Egg == true)
                        {
                            GrillSlot3Vaule = 2;
                        }
                        else if (PlayerPickUpScript.UncookedRice == true)
                        {
                            GrillSlot3Vaule = 3;
                            //PlayerPickUpScript.CookedRice = true;
                        }
                        else if (PlayerPickUpScript.Vegitible == true)
                        {
                            GrillSlot3Vaule = 4;
                        }
                    }
                }
                }
            }
        }
        
}
