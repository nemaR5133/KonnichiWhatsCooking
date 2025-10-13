/*
 * Name: Ryan Scheppler
 * Date: 9/25/24
 * Desc: 2d movement for a top down game
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Tooltip("Acceleration")]
    public float accel = 100;

    private Vector3 inputMovement = Vector3.zero;
    private Rigidbody2D myRb;
    // Start is called before the first frame update
    void Start()
    {
        myRb = GetComponent<Rigidbody2D>();
    }
    // FixedUpdate is called once per physics update
    private void FixedUpdate()
    {
        myRb.AddForce( inputMovement.normalized *  accel );
    }

    // Update is called once per frame
    void Update()
    {
        inputMovement.x = Input.GetAxisRaw("Horizontal");
        inputMovement.y = Input.GetAxisRaw("Vertical");
    }
}
