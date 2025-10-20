using UnityEngine;

public class PickItUp : MonoBehaviour
{
    public bool handsFull;
    public GameObject player;
    public GameObject egg;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        handsFull = false;
    }

    private void OnCollisionStay2D(Collision2D food)
    {
        if (handsFull == false)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (food.gameObject.CompareTag("EggCrate"))
                {
                    GameObject clone = Instantiate(egg, player.transform);
                    handsFull = true;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
