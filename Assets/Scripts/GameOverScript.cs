using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    Text win;
    public bool gameOver = false;

    void Start()
    {
        win = GetComponent<Text> ();
        win.text = "";
    }


    void Update()
    {
        if(ScoreScript.scoreValue >= 4)
        {
            win.text = "You Win! Game Created by Roque Tacsa. Press R to restart";
            gameOver = true;
        }
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (gameOver == true)
            {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}