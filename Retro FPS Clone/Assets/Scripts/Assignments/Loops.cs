using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{

    [Header("For Loop Variables")]
    public int numEwoks = 0;
    public int levelCap = 15;
    public int maxCupcakes = 10;
    public int timeOut = 0;
    public int villageEmpty = 0;

    [Header("While Loop Variables")]
    public int ducksInPond = 99;
    public int goldCoins = 0;
    public int skeletons = 10;
    public int noponDubloons = 0;
    public int goldfish = 50;
    

    // Start is called before the first frame update
    void Start()
    {
        //for(Declaration; Condition; Iteration)

        for(int i = 20; i >= numEwoks; i--)
        {
            Debug.Log("There are " + i + (" Ewoks on a log!"));
        } 

        for(int i = 0; i <= levelCap; i++)
        {
            Debug.Log("You are now level " + i);
        }
        
        for(int i = 0; i < maxCupcakes; i++)
        {
            Debug.Log("Keep going!  You've only had " + i + " Cupcakes!");
        }

        for(int i = 20; i > timeOut; i--)
        {
            Debug.Log("Only " + i + "second(s) left!!");
        }

        for(int i = 30; i > villageEmpty; i--)
        {
            Debug.Log("The village is being attacked! Get everyone out!");
        }

          
        
        while(ducksInPond > 0)
        {
            Debug.Log(ducksInPond);
            Debug.Log("All of the ducks have flown south for the winter");
            ducksInPond --;
        }

        while(goldCoins < 10)
        {
            Debug.Log("You cannot afford this.");
            goldCoins++;
        }

        while(skeletons > 0)
        {
            Debug.Log("There are still " + skeletons + " skeletons.  Keep shooting!");
            skeletons--;
        }

        while(noponDubloons < 12)
        {
            Debug.Log("You have collected " + noponDubloons + "Nopon Dubloons");
            noponDubloons++;
        }

        while(goldfish > 0)
        {
            Debug.Log("Goldfish for sale!");
            goldfish--;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
