using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    // How arrays order { 0, 1, 2, 3, 4, 5, 6}
    public string[] friendNames = {"Bob", "Jessica", "Jodi", "Arthur", "Randall", "Todd", "Becky"};

    public string[] dreamCars = {"Aventador", "Challenger", "Crosstrek"};

    public string[] drivers = {"Rex", "Nia", "Tora", "Morag", "Zeke"};
    
    public string[] blades = {"Pyra", "Dromarch", "Poppi", "Brighid", "Pandoria"};

    public string[] elements = {"Fire", "Water", "Wind", "Ice", "Electric", "Earth", "Light", "Dark"};

    public string[] prisonerList = {"Ulfric Stormcloak, Jarl of Windhelm", "Ralof of Riverwood", "Lokir of Rorikstead"};

    public int[] numbers = {23, 75, 84, 2, 16, 81, 10};

    public int[] goldValues = {20, 25, 30, 35, 40, 50, 70, 100};

    public int[] luckyNumbers = {7, 13, 18, 21, 42, 69};

    public float[] damageMultiplier = {1.00f, 0.75f, 0.90f, 1.25f, 1.5f, 1.75f, 2.00f};

    

    

    
    
    
    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log("Former friend " + friendNames[0]);
        Debug.Log(friendNames[3] +" says Wazzzup as he walks to class");
        friendNames[0] = "Veronica";
        Debug.Log("New friend " + friendNames[0]);
        */

        //for each item in the array, this loop will run as many times as there are item in the array
        /*foreach(int numbers in numbers)
        {
            print(numbers + " Cabbages");
        }
        


        Debug.Log("The Element of " + elements[0] + " is very effective against Krabbles and will multiply your damage by " + damageMultiplier[4]);
        */
    }
}
