using UnityEngine;
using UnityEngine.UI;
/*****************************************************************
 * File Name: CookingStationIntrractScript
 * Author: Dante Jones
 * Digipen Email: jones.d@digipen.edu
 * Course: GAM100
 * Descriptoin:
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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Setting the image Active to false
        CookingGameImage.gameObject.SetActive(false);
        //Setting the Button Active to false
        CookingGameButton.gameObject.SetActive(false);
    }

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
    }
    //Checking if player has entered trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Check if tage is stove game.
        if (collision.tag == "StoveGame")
        {
            //Setting the stove being touched to true
            StoveIsTouched = true;
        }
    }
}
