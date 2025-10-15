using UnityEngine;

public class QuickTimeEventPlayOne : MonoBehaviour
{
    //Setting how many times button can be press before being destroyed
    public int TimesButtonPressed;
    //Saves original vaulue
    public static int OriginalVauleSaved;
    //Makes a public static that saves the TimesButtonPressed value
    public static int TimesButtonPressedVauleSaved;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Set TimesButtonPressedVauleSaved the same value as TimesButtonPressed
        TimesButtonPressedVauleSaved = TimesButtonPressed;
        //Set OriginalVauleSaved the same value as TimesButtonPressed
        OriginalVauleSaved = TimesButtonPressed;
    }

    // When the button is pressed.
    public void PressTheButton()
    {
        //Remove one from TimesButtonPressedVauleSaved
        TimesButtonPressedVauleSaved -= 1;
    }
}
