using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float movespeed = 5.0f;  // Speed at which the player moves
    private Rigidbody2D rb;  // Store the referenced 2D Rigidbody

    //Vector2(X,Y)
    Vector2 movement; // Store the Players x,y position for movment

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal"); // Input for Left Right Movement
        movement.y = Input.GetAxis("Vertical"); // Input for Up Down Movement
    }

    //Set number of calls per frame, better for physics
    void FixedUpdate()
    {
        //Apply physics and move the character
        rb.MovePosition(rb.position + (movement * movespeed * Time.deltaTime));
    }
}
