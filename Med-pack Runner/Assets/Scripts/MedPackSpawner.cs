using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedPackSpawner : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;

    private bool isCreated;

    public MedPack medPack;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnPack()
    {

        if(!isCreated) 
        {
            Instantiate(medPack, new Vector3(Random.Range(minX,maxX), 0.5f, Random.Range(minZ,maxZ)), Quaternion.identity);
            isCreated = true;
        }
    }
}
