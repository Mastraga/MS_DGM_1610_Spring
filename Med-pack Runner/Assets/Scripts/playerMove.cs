using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float movespeed = 5.0f;

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
    }

    //FixedUpdate() is a monobehaviour built in to unity
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + (movement * movespeed * Time.deltaTime));
    }
}
