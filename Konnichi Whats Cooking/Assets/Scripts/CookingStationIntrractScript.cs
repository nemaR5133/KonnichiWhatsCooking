using UnityEngine;
using UnityEngine.UI;
/*****************************************************************
 * File Name: CookingStationIntrractScript
 * Author: Dante Jones
 * Digipen Email: jones.d@digipen.edu
 * Course: GAM100
 * Descriptoin: This is the script for nteratng with the cooking stations.
 * And player can go up to them and press E to start the game.
 * 
 * 
 * ***************************************************************
 */

public class CookingStationIntrractScript : MonoBehaviour
{
    //This is the Image of the game
    public Image CookingGameImage;
    //Screen wide button for game
    public Button CookingGameButton;
    //The Stove has not been touched check
    public bool StoveIsTouched = false;
    public bool CounterIsTouched = false;
    public GameObject MixingCirlce;

    /****************************************************
    *Function: Start
    *
    *Description: First thing that runs. Sets the ui elements inactive.
    *
    *Inputs: Ui elements- The minigame in itself.
    *
    *Outputs: Turns ui elements off. Not active.
    * 
    ****************************************************/
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Setting the image Active to false
        CookingGameImage.gameObject.SetActive(false);
        //Setting the Button Active to false
        CookingGameButton.gameObject.SetActive(false);
    }

    /****************************************************
    *Function: Update
    *
    *Description: Checks if stove is touched every frame. 
    *Then if e is pressed re-enable Ui elements
    *
    *Inputs: Player Input - Player presses E.
    *
    *Outputs: The Ui elements will appear.
    * 
    ****************************************************/

    // Update is called once per frame
    void Update()
    {
        //Checking if the stove is touched
        if (StoveIsTouched == true)
        {

            //Checking if E has been pressed.
            if (Input.GetKeyDown(KeyCode.E))
            {
                //Setting the image Active to true
                CookingGameImage.gameObject.SetActive(true);
                //Setting the Button Active to true
                CookingGameButton.gameObject.SetActive(true);
            }
        }
        // If TimesButtonPressedVauleSaved = 0 then turn off the UI
        if (QuickTimeEventPlayOne.TimesButtonPressedVauleSaved == 0)
        {
            //Setting the image Active to false
            CookingGameImage.gameObject.SetActive(false);
            //Setting the Button Active to false
            CookingGameButton.gameObject.SetActive(false);
        }
    }
    /****************************************************
    *Function: OnTriggerEnter2D
    *
    *Description: When the player enters the stove it will set the bool StoveIsTouched true.
    *
    *Inputs: Player Interaction- When the player enteres the trigger area then it ill 
    *function.
    *
    *Outputs: Setting the StoveIsTouched Bool true.
    * 
    ****************************************************/
    //Checking if player has entered trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Check if tage is stove game.
        if (collision.tag == "StoveGame")
        {
            //Setting the stove being touched to true
            StoveIsTouched = true;
        }
        if (collision.CompareTag("MixingGame"))
        {
            CounterIsTouched = true;
        }
    }
    //WHen the quick time is exited
    private void OnTriggerExit2D(Collider2D collision)
    { 
        //IF the collsion is STOVEGAME
        if (collision.tag == "StoveGame")
        {
            //When the button is pressed enogh times & player has exited

            if (QuickTimeEventPlayOne.TimesButtonPressedVauleSaved == 0)
            {
                //Then when they leave the vaule will be reset
                QuickTimeEventPlayOne.TimesButtonPressedVauleSaved = QuickTimeEventPlayOne.OriginalVauleSaved;
            }
            //They are not touching the stove.
            StoveIsTouched = false;
        }
        if (collision.CompareTag("MixingGame"))
        {
            //trigger mixing event//
            //Activates the circles which will detect if the mouse is colliding with them. The player has to collide with all of them to complete the event//
            MixingCirlce.gameObject.SetActive(true);
            
           
        }
        CounterIsTouched = false;
    }
}
