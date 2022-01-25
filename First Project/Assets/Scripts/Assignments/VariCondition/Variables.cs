using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    public int money; //Whole number value 7, 34, -83, 452

    public float change; // Floating point number or decimal amount 3.14, 6.73, -573.2

    public bool isDay; // Booleans are true or false

    private string firstName; // Strings are alphanumeric lines of text contained in quotation marks


    // Start is called before the first frame update
    void Start()
    {
        money = 125;
        Debug.Log("Money in account = $" + money); // This command is the same as print
        
    }

    // Update is called once per frame
    void Update()
    {
        if(money >= 100)
        {
            print("You have sufficient funds");
        }
        else if(money < 100)
        {
            Debug.Log("Come back when you've got some real coin");
        }
        
    }
}
