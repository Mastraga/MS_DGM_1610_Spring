using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float movespeed = 5.0f;
    private float turnSpeed = 180f;
    private float rInput;

    private float fInput;
    private float hInput;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        fInput = Input.GetAxis("Vertical");
        rInput = Input.GetAxis("Mouse X");

        if(Input.GetButton("Sprint"))
        {
            movespeed = 8.0f;
        }
        else
        {
            movespeed = 5.0f;
        }

        transform.Translate(Vector3.right * hInput * Time.deltaTime * movespeed);
        transform.Translate(Vector3.forward * fInput * Time.deltaTime * movespeed);
        transform.Rotate(Vector3.up * rInput * Time.deltaTime * turnSpeed);
    }

    /*FixedUpdate() is a monobehaviour built in to unity
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + (movement * movespeed * Time.deltaTime));
    }*/
}
