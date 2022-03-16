using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{

    public GameObject block;
    int height = 4;
    int width = 10;


    // Start is called before the first frame update
    void Start()
    {
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                Instantiate(block, new Vector3(x,y,0), Quaternion.identity); //keyword "new" used for initializing a coordinate
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
