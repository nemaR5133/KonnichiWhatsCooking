using UnityEngine;
/*****************************************************************
 * File Name: IndergientPopUpScript
 * Author: Dante Jones
 * Digipen Email: jones.d@digipen.edu
 * Course: GAM100
 * Descriptoin: This script is for when the player walks up to a 
 * crate it will give them a E button prompt image Please set the 
 * image and were it Appears.
 ****************************************************************/
public class ingredientPopUpScript : MonoBehaviour
{

    //The First Pop Up
    public GameObject PopUp;
    //The position obove Crate
    public GameObject CratePopPos;
    //Clone Of Pop Up
    public GameObject PopUp1Colne;
    //Checks if the era has been enter.
    bool CrateEntered = false;

    /****************************************************
     *Function: OnTriggerEnter2D
     *
     *Description: This function decteds if the player has entered the trigger
     *Then the pop up wil appear.
     *
     *Inputs: Player Interaction- Player enters the trigger. Crate entered bool. 
     *
     *Outputs: Creates the prefab for pop up
     * 
     ****************************************************/
    //Checks if player enters Trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {

            //Checks if player has not entered crate area
            if (CrateEntered == false)
            {

                //Checks tag of trigger if it is "ingredientPopUp" then create the pop up
                if (collision.tag == "Player")
                {
                    //Sets the PopUp Position to the create.
                    PopUp.transform.position = CratePopPos.transform.position;
                    //Make Pop up clone 
                    PopUp1Colne = Instantiate(PopUp);
                    //Tells the bool player has entered
                    CrateEntered = true;
                }

            }

        
    }

    /****************************************************
     *Function: OnTriggerExit2D
     *
     *Description: Destroys pop up when player leaves.
     *
     *Inputs: Player Interaction- Player exiting trigger.
     *
     *Outputs: The pop up will be destroyed.
     * 
     ****************************************************/
    //Checks if trigger has been exited
    private void OnTriggerExit2D(Collider2D collision)
    {
        //Checks if player is in Crte Area
        if (CrateEntered == true)
        {
            //Checks tag
            if (collision.tag == "Player")
            {
                //Destroys pop up clone
                Object.Destroy(PopUp1Colne);
                //Tells the bool player has exited
                CrateEntered = false;
            }
        }
    }
}

