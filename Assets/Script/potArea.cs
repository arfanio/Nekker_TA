using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class potArea : MonoBehaviour
{
    public static int scorePoint = 0;
    public Text ScoreText;
    public int MaxScore;
    public GameObject Gameover;
    // public Text ScoreText;


    // Use this for initialization

    void OnTriggerExit (Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            scorePoint += 1;
            Destroy (other.gameObject,2f);
        }
    }
    void Update(){
        ScoreText.text = "Score = " + scorePoint.ToString("F0") ;
        if(scorePoint == MaxScore){
            Gameover.SetActive(true);
            // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
