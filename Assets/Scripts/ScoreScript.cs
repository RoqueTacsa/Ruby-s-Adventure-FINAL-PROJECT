using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    public static int pepperValue = 0;
    public static int scoreValue = 0;
    Text score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text> ();
    }

    void Update() {
    Scene scene = SceneManager.GetActiveScene();

    //determining which win conditions to set
    if (scene.name == "MainScene") 
     {score.text = "Fixed Robots: " + scoreValue;}
    if (scene.name == "SecondScene") 
     {score.text = "Peppers Collected: " + pepperValue;}
    }
}
