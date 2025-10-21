/*******************************************************************
 * File name: PlayerController
 * Author: Nathen Mattis
 * Digipen Email: 1119065@lwsd.org
 * Course: Game100
 * 
 * Description: Moves player on input, as well as animates the player
 ********************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Tooltip("Acceleration")]
    public float playerSpeed = 100;
    public Animator anim;

    private Vector2 moveDirection;
    private Vector2 lastMoveDirection;
    private Rigidbody2D myRb;

    // Start is called before the first frame update
    void Start()
    {
        myRb = GetComponent<Rigidbody2D>();
    }
    // FixedUpdate is called once per physics update
    private void FixedUpdate()
    {
        Move();
        Animate();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }

    // Processes the inputs given, doesn't actually move the player
    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        if((moveX == 0 && moveY == 0) && moveDirection.x != 0 || moveDirection.y != 0)
        {
            lastMoveDirection = moveDirection;
        }

        moveDirection = new Vector2(moveX, moveY);
    }

    // Actually moves the player's position
    void Move()
    {
        myRb.velocity = new Vector2(moveDirection.x * playerSpeed, moveDirection.y * playerSpeed);
    }

    // Tells the Animator to change numbers to our current direction, then projects a different animation accordingly
    void Animate()
    {
        anim.SetFloat("AnimMoveX", moveDirection.x);
        anim.SetFloat("AnimMoveY", moveDirection.y);

        anim.SetFloat("AnimMoveMagnitude", moveDirection.magnitude);

        anim.SetFloat("AnimLastMoveX", lastMoveDirection.x);
        anim.SetFloat("AnimLastMoveY", lastMoveDirection.y);
        //anim.SetFloat("isMoving", true);
    }

}
