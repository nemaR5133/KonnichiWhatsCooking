using UnityEngine;

public class PickItUp : MonoBehaviour
{
    // Bool that checks if the player's hands are already full
    public bool handsFull;
    // The player gameobject
    public GameObject player;
    // A test object I am using to check if the player can pick up objects
    public GameObject egg;
    public GameObject counter;
    private bool pickUp;
    private bool setDown;
    private GameObject clone;
    public GameObject Place;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        handsFull = false;
    }

    // When the player enters the collision of the ingredient crate
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (handsFull == false)
        {
            Debug.Log("CHecking input");
            if (pickUp)
            {
                pickUp = false;
                Debug.Log("Hit E");
                if (collision.gameObject.CompareTag("EggCrate"))
                {
                    // Code instantiates a copy of the test object
                    clone = Instantiate(egg, player.transform);
                    handsFull = true;
                }
            }
        }
        if (handsFull == true)
        {
            if (setDown)
            {
                setDown = false;
                if (collision.gameObject.CompareTag("Countertop"))
                {
                    GameObject tableClone = Instantiate(egg, Place.transform);
                    tableClone.transform.position = Place.transform.position;
                    handsFull = false;
                    Destroy(clone);
                }
            }
        }
    }







    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && handsFull == false)
        {
            pickUp = true; 
        }
        else if (Input.GetKeyDown(KeyCode.E) && handsFull == true)
        {
            setDown = true;
        }

    }
}
