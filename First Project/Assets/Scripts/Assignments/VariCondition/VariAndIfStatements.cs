using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariAndIfStatements : MonoBehaviour
{

    //Variable Declaration

    public int dollars;

    public float cents;

    public bool fullMoon;

    public string username = "OracleMS";

    public string password = "M3rc3r2254";



    // Start is called before the first frame update
    void Start()
    {
        dollars = 100;
        cents = 0.45f;
        fullMoon = true;
    }

    // Update is called once per frame
    void Update()
    {


        //Testing Integer Variable

        if(dollars >= 100)
        {
            Debug.Log("You have enough money");
        }
        else
        {
            Debug.Log("Come back when you've got some real coin!");
        }


        //Testing Float Variable

        if(cents == 0.45f)
        {
            Debug.Log("You have exact change, good job!");
        }
        else if(cents >= 0.45f)
        {
            Debug.Log("Would you like your change?");
        }
        else if(cents <= 0.45f)
        {
            Debug.Log("You'll need a few extra coins there.");
        }    


        //Testing Boolean variable
        
        if(fullMoon)
        {
            Debug.Log("Best find shelter for the night.");
        }
        else
        {
            Debug.Log("Lovely evening, isn't it?");
        }


        //Testing string username variable
        
        if(username == "OracleMS")
        {
            Debug.Log("Welcome back " + username);
        }
        else
        {
            Debug.Log("Incorrect Username");
        }


        //Testing string password variable

        if(password == "M3rc3r2254")
        {
            Debug.Log("Password Correct");
        }
        else
        {
            Debug.Log("Incorrect Password");
        }

        
        //The following are tests of logical operators

        if(dollars >= 100 && cents == 0.45f)
        {
            Debug.Log("You have enough money AND exact change!!!");
        }
        else if(dollars < 100 && cents == 0.45f)
        {
            Debug.Log("You're missing a few dollars there");
        }

        if(dollars >= 100 && !fullMoon)
        {
            Debug.Log("I see your pockets are full.  Be on your way.");
        }
        else if(dollars >= 100 && fullMoon)
        {
            Debug.Log("I see your pockets are full.  Unfortunately no amount of money is going to save you tonight.");
        }

        if(username == "OracleMS" || username == "MaskedMS" || username == "EtherealMS")
        {
            Debug.Log("Welcome home one of many masters");
        }
        else
        {
            Debug.Log("Leave!  You are not part of the legion!");
        }

            
    }
}
