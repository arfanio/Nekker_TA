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
    // public Text ScoreText;


    // Use this for initialization

    // void OnTriggerEnter (Collider other)
    //         {
    //             if (speed < 0.5){
    //                 if (other.gameObject.tag == "Gaco")
    //                 {
    //                     Debug.Log("Anda Mati");
    //                 }
    //             }
                
    //         }
     


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
            // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
