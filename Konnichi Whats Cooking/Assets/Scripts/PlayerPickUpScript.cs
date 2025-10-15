using UnityEngine;

public class PlayerPickUpScript : MonoBehaviour
{
    bool IsHoldingItem = false;

    //Ingredients 
    bool UncookedRice;
    bool CookedRice;
    bool Bread;
    bool Egg;
    bool Vegitible;
    bool Seaweed;
    bool Fish;
    bool UncutMochi;

    //Dishes
    bool Okonomiyaki;
    bool Mochi;
    bool Onigiri;
    bool TamagoSando;
    bool MisoSoup;
    bool WakameSalad;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
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
