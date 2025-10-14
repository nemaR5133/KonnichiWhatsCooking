using UnityEngine;
/*****************************************************************
 * File Name: IndergientPopUpScript
 * Author: Dante Jones
 * Digipen Email: jones.d@digipen.edu
 * Course: GAM100
 * Descriptoin: This script is for when the player walks up to a 
 * crate it will give them a E button prompt image Please set the 
 * image and were it Appears.
 * ***************************************************************
 */
public class ingredientPopUpScript : MonoBehaviour
{

    //The First Pop Up
    public GameObject PopUp1;
    //The position obove Crate
    public GameObject CratePopPos1;
    //Clone Of Pop Up
    public GameObject PopUp1Colne;
    //Checks if the era has been enter.
    bool CrateEntered = false;


    //Checks if player enters Trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {

            //Checks if player has not entered crate area
            if (CrateEntered == false)
            {

                //Checks tag of trigger if it is "ingredientPopUp" then create the pop up
                if (collision.tag == "ingredientPopUp")
                {
                    //Sets the PopUp Position to the create.
                    PopUp1.transform.position = CratePopPos1.transform.position;
                    //Make Pop up clone 
                    PopUp1Colne = Instantiate(PopUp1);
                    //Tells the bool player has entered
                    CrateEntered = true;
                }

            }

        
    }


    //Checks if trigger has been exited
    private void OnTriggerExit2D(Collider2D collision2)
    {
        //Checks if player is in Crte Area
        if (CrateEntered == true)
        {
            //Checks tag
            if (collision2.tag == "ingredientPopUp")
            {
                //Destroys pop up clone
                Object.Destroy(PopUp1Colne);
                //Tells the bool player has exited
                CrateEntered = false;
            }
        }
    }
}

