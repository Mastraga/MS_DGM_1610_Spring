using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    public string npcConv;

    public int socialClass = 1;

    public float health = 100;


    void Start()
    {
        switch(npcConv)
        {
            case "Hello":
             print("Hello good citizen.  May the blessings of zandar be upon you");
             break;
            case "Goodbye":
             print("Goodbye.  Safe travels to you and your party");
             break;
            case "We are being attacked":
             print("You run away in shame, you coward!");
             break;
        }
        
        switch(socialClass)
        {
            case 5:
             Debug.Log("Hello, your Magesty");
             break;
            case 4:
             Debug.Log("Hello Young Prince");
             break;
            case 3:
             Debug.Log("Good evening Duke Urthor");
             break;
            case 2:
             Debug.Log("Hello, Governor");
             break;
            case 1:
             Debug.Log("Hello, merchant");
             break;
            case 0:
             Debug.Log("Get away from me peasant");
             break;
            default:
             Debug.Log("I do not talk with strangers");
             break;
        }

        switch(health)
        {
            case 100:
             Debug.Log("Health is 100");
             break;
            case 50:
             Debug.Log("Health is 50");
             break;
            case 0:
             Debug.Log("Health is 0.  Player has died");
             break;
        }
        
    }


}
