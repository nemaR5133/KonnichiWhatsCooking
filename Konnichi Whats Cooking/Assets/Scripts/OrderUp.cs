using UnityEngine;

public class OrderUp : MonoBehaviour
{
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

        }
    }
}
