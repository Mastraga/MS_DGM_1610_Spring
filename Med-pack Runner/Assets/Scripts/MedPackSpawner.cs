using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedPackSpawner : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;

    public GameObject medPack;

    // Start is called before the first frame update
    void Start()
    {
        medPack = GameObject.Find("MedPack");
        spawnPack();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void spawnPack()
    {
        Instantiate(medPack, new Vector3(Random.Range(minX,maxX), 0.5f, Random.Range(minZ,maxZ)), Quaternion.identity);
    }
}
