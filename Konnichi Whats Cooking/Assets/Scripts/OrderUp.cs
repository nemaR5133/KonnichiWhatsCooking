using UnityEngine;

public class OrderUp : MonoBehaviour
{
<<<<<<< HEAD

=======
>>>>>>> 495c6d7abdda31deeab87a56c08517530adde0ee
    public float cooldown;
    public float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < cooldown)
        {
            timer += Time.deltaTime;
        }
        else
        {
<<<<<<< HEAD
            
=======

>>>>>>> 495c6d7abdda31deeab87a56c08517530adde0ee
        }
    }
}
