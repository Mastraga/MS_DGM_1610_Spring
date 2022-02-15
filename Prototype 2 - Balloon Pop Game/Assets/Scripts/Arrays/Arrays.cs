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

    public int[] numbers = {23, 75, 84, 2, 16, 81, 10};

    

    
    
    
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
        foreach(int numbers in numbers)
        {
            print(numbers + " Cabbages");
        }
    }
}
