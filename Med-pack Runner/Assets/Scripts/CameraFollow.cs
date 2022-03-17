using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    GameObject player;
    private Vector3 offset = new Vector3(0,2,-5);

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
        transform.RotateAround(player.transform.position, Vector3.up, 0);
    }

    void FixedUpdate()
    {
        //transform.position = player.transform.position + offset;
    }
}
