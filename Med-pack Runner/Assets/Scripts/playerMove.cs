using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float movespeed = 5.0f;
    //private float turnSpeed = 50f;
    private Vector3 movement;
    private Rigidbody rb;
    
    public float rInput;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");
        //rInput = Input.GetAxis("Mouse X");

        //transform.Rotate(Vector3.up * rInput * Time.deltaTime * turnSpeed);
    }

    //FixedUpdate() is a monobehaviour built in to unity
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + (movement * movespeed * Time.deltaTime));
    }
}
