using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class potArea : MonoBehaviour
{
    public static int scorePoint = 0;
    float speed;
    public Text ScoreText;
    public Rigidbody ball_1;
    public int MaxScore;
    public GameObject Gameover;

    void OnTriggerExit (Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            scorePoint += 1;
            Destroy (other.gameObject,2f);
        }
        if(scorePoint == MaxScore){
            save_point.simpan_skor();
        }
    }
    void Update(){
        
        ScoreText.text = "Score = " + scorePoint.ToString("F0") ;
        
        if(scorePoint == MaxScore){
            Gameover.SetActive(true);
            scorePoint = 0;
        }
    }
}
