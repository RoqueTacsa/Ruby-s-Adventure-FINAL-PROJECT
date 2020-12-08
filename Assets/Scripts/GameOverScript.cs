using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    Text win;
    public bool gameOver;

    void Start()
    {
        win = GetComponent<Text> ();
        win.text = "";
        gameOver = false;
    }


    void Update()
    {
        if(ScoreScript.scoreValue >= 4)
        {
            win.text = "You Win! Press X to visit stage two!";
            gameOver = true;
        }
        
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (gameOver == true)
            {
            SceneManager.LoadScene("SecondScene");
            ScoreScript.scoreValue = 0;
            }
        }
        if(ScoreScript.pepperValue >= 25)
        {
            win.text = "You Win! Game created by Roque Tacsa! Press R to restart.";
            gameOver = true;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (gameOver ==true)
            {
                SceneManager.LoadScene("MainScene");
                ScoreScript.pepperValue = 0;
            }
        }
    }
}