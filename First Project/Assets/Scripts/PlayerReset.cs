using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReset : MonoBehaviour
{
    private Vector3 spawnPoint = new Vector3(0,2,0);
    bool reset = false;
    float resetPress;

    // Update is called once per frame
    void Update()
    {
        resetPress = Input.GetAxis("Cancel");

        if(resetPress == 1)
        {
            reset = true;
        }    
                        
        //Resets when Cancel is pressed
        if(reset == true)
        {
            transform.position = spawnPoint;
            reset = false;
        }
    }
}
