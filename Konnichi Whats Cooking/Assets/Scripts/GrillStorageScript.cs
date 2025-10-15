using UnityEngine;

public class GrillStorageScript : MonoBehaviour
{
    bool GrillSlot1;
    bool GrillSlot2;
    bool GrillSlot3;
    int GrillSlot1Vaule;
    int GrillSlot2Vaule;
    int GrillSlot3Vaule;

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
                     if (PlayerPickUpScript.)
                    {

                    }
                    }
                    else if ( GrillSlot2 == false)
                    {

                    }
                    else if (GrillSlot3 == false)
                    {

                    }
                }
            }
        }
        
}
