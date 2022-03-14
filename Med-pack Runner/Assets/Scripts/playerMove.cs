using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float movespeed = 5.0f;
    public float turnSpeed = 5.0f;

    private float rInput;
    private Vector3 movement;
    private Rigidbody rb;

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
        rInput = Input.GetAxis("Mouse X");
    }

    //FixedUpdate() is a monobehaviour built in to unity
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + (movement * movespeed * Time.deltaTime));
        transform.Rotate(Vector3.up * rInput * turnSpeed * Time.deltaTime);
    }
}
