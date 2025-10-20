using UnityEngine;
using UnityEngine.UI;
public class WaitressScript : MonoBehaviour
{
    public GameObject WaitressPos;
    public GameObject Waitress;
    public GameObject WaitressClone;
    public GameObject WaitressPopUp;
    public GameObject WaitressPopUpPos;
    public GameObject WaitressPopUpClone;
    public Image DishImage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DishImage.gameObject.SetActive(false);            
        WaitressClone.transform.position = WaitressPos.transform.position;
        WaitressClone = Instantiate(Waitress);
        DishImage.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Bell")
        {


        }
    }
}
