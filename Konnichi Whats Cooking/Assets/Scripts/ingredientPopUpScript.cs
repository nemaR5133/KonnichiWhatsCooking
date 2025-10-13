using UnityEngine;

public class ingredientPopUpScript : MonoBehaviour
{
    //The First Pop Up
    public GameObject PopUp1;
    //The position obove Crate
    public GameObject CratePopPos1;
    //Checks if the era has been enter.
    bool CrateEntered = false;
    //Checks if player enters Trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (CrateEntered == false)
        {
        //Checks tag of trigger if it is "ingredientPopUp" then create the pop up
        if (collision.tag == "ingredientPopUp")
        {
            //Sets the PopUp Position to the create.
            PopUp1.transform.position = CratePopPos1.transform.position;
            //Make Pop up
            Instantiate(PopUp1);
            //Tells the bool player has entered
            CrateEntered = true;
        }
        }

    }
    //Checks if trigger has been exited
    private void OnTriggerExit2D(Collider2D collision2)
    {
        if (CrateEntered == true)
        {
            //Checks tag
            if (collision2.tag == "ingredientPopUp")
            {
                //Destroys pop up
                DestroyImmediate(PopUp1,true);
                //Tells the bool player has exited
                CrateEntered = false;
            }
        }
    }
}

