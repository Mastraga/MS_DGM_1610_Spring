using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedPack : MonoBehaviour
{
    float rotateSpeed = 180;
    public MedPackSpawner medPackSpawner;

    // Start is called before the first frame update
    void Start()
    {
        medPackSpawner = GameObject.Find("MedPackSpawner").GetComponent<MedPackSpawner>();
        medPackSpawner.spawnPack();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
    }


     void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            destroyPack();
            medPackSpawner.spawnPack();
        }
    }


    void destroyPack()
    {
        Destroy(gameObject);
    }
}
