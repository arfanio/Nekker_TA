using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class potArea : MonoBehaviour
{
    public int scorePoint = 0;
    public Text ScoreText;
    public int MaxScore;
    public bool player1;
    public bool player2;
    public GameObject Gameover;
    // public Text ScoreText;


    // Use this for initialization
    void Update(){
        
        ScoreText.text = "Score = " + scorePoint.ToString("F0") ;
        if(scorePoint == MaxScore){
            Gameover.SetActive(true);
            // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            scorePoint += 1;
            Destroy (other.gameObject,2f);
        }
    }
    
}
