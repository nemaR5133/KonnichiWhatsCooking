using UnityEngine;

public class MouseFollower : MonoBehaviour
{
    public CookingStationIntrractScript counter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mousePos;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("MixingGameCirlce"))
        {
            Debug.Log("Cirlce");
            counter.MixCircleHit();
            collision.gameObject.SetActive(false);
           
        }
    }
}
