using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int scoreToGive = 100;  // Score given for popped balloon

    public int clickToPop = 3;  // How many clicks before balloon pops

    public float scaleToIncrease = 0.10f; // Scale increase when balloon is clicked

    public ScoreManager scoreManager;  // A variable to reference the ScoreManager script


    // Start is called before the first frame update
    void Start()
    {
        //Reference ScoreManager Component
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        // Reduce clicks by one
        clickToPop -= 1;

        //Increase size of balloon
        transform.localScale += Vector3.one * scaleToIncrease;

        if(clickToPop == 0)
        {
            scoreManager.IncreaseScoreText(scoreToGive);
            Destroy(gameObject);
        }
    }
}
