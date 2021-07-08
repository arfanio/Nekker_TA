using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Mirror;

public class potAreaNET : NetworkBehaviour
{
    // public static int scorePoint = 0;
    public static int scorePointP1 = 0;
    public static int scorePointP2 = 0;
    public static int totalScorePoint = 0;
    float speed;
    // public Text ScoreText;
    public Text ScoreTextP1;
    public Text ScoreTextP2;
    GameObject ball_1;
    GameObject ball_2;
    Rigidbody ball_1_TR;
    Rigidbody ball_2_TR;
    public int MaxScore;
    public GameObject Gameover;
    


    // Use this for initialization
    void Start(){
        if (isLocalPlayer)
            {
                
                if (isServer )
                {
                    ball_1 = GameObject.FindWithTag("Gaco");
                    ball_1_TR = GetComponent<Rigidbody>();
                    Debug.Log("Gaco Server");
                    // transform.position = ball_1.position;
                    
                }
                if (isClient)
                {
                    ball_2 = GameObject.FindWithTag("Gaco");
                    ball_2_TR = GetComponent<Rigidbody>();
                    Debug.Log("Gaco Client");
                    // transform.position = ball_2.position;

                    
                }
            }
    }
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
            scorePointP1 += 1;
            Destroy (other.gameObject,2f);
        }
        if(scorePointP1 == MaxScore){
            save_point.simpan_skor();
        }
    }
    void Update(){
        
        ScoreTextP1.text = "Score = " + scorePointP1.ToString("F0") ;
        ScoreTextP2.text = "Score = " + scorePointP2.ToString("F0") ;

        
        if(scorePointP1 == MaxScore){

            Gameover.SetActive(true);
            scorePointP1 = 0;
            Debug.Log("ulangteross");
            // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
