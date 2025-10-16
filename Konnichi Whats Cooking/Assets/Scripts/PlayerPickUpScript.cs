using UnityEngine;

public class PlayerPickUpScript : MonoBehaviour
{
    public static bool IsHoldingItem = false;

    //Ingredients 
    public static bool UncookedRice;
    public static bool CookedRice;
    public static bool Bread;
    public static bool Egg;
    public static bool Vegitible;
    public static bool Seaweed;
    public static bool Fish;
    public static bool UncutMochi;
    public static bool Batter;


    //Dishes
    public static bool Okonomiyaki;
    public static bool Mochi;
    public static bool Onigiri;
    public static bool TamagoSando;
    public static bool MisoSoup;
    public static bool WakameSalad;
    public static bool PanCakaki;

    //The Ingredents cooked
    public static bool EggIsCooked;
    public static bool VegitibleIsCooked;

    private void OnTriggerStay2D(Collider2D collision)
    {
            //If the E key is pressed
            if (Input.GetKeyDown(KeyCode.E))
            {
            //If player is not holding item.
            if (IsHoldingItem == false)
            {
            
                //Gets the Uncooked rice
                if (collision.tag == "UncookedRiceCrate")
                {
                    UncookedRice = true;
                    print("Uncooked rice");
                    IsHoldingItem = true;
                }

                //Gets the bread
                if (collision.tag == "BreadCrate")
                {
                    Bread = true;
                    print("Bread");
                    IsHoldingItem = true;
                }

                // Gets the eggs
                if (collision.tag == "EggCrate")
                {
                    Egg = true;
                    print("Egg");
                    IsHoldingItem = true;
                }

                // Get the Vegitibles
                if (collision.tag == "VegitibleCrate")
                {
                    Vegitible = true;
                    print("Vegitible");
                    IsHoldingItem = true;
                }

                //Get the Seaweed
                if (collision.tag == "SeaweedCrate")
                {
                    Seaweed = true;
                    print("Seaweed");
                    IsHoldingItem = true;
                }

                //Get the Fish
                if (collision.tag == "FishCrate")
                {
                    Fish = true;
                    print("Fish");
                    IsHoldingItem = true;
                }

                //Get the mochi
                if (collision.tag == "UncutMochiCrate")
                {
                    UncutMochi = true;
                    print("UncutMochi");
                    IsHoldingItem = true;
                }
            }
            }
       
    }
}
