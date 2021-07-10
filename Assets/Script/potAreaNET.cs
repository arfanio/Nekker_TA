using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Mirror;

public class potAreaNET : NetworkBehaviour
{
    public static int scorePointP1 = 0;
    public static int scorePointP2 = 0;
    public static int totalScorePoint = 0;
    public Text ScoreTextP1;
    public Text ScoreTextP2;
    public int MaxScore;
    public static bool lifeP1 = false;
    public static bool lifeP2 = false;
    public GameObject Gameover;
    public GameObject loveP1_1;
    // public GameObject loveP1_2;
    public GameObject loveP2_1;
    // public GameObject loveP2_2;
    

    void OnTriggerEnter (Collider other)
            {
                if (other.gameObject.tag == "Gaco" && player.giliranP1 == true )
                    {
                        lifeP2 = true;
                        Debug.Log("P2 Mati");
                        Debug.Log("lifeP1");
                        Destroy(loveP2_1.gameObject);
                    }
                if (other.gameObject.tag == "Gaco" && player.giliranP2 == true )
                    {
                        lifeP1 = true;
                        Debug.Log("P1 Mati");
                        Debug.Log("lifeP2");
                        Destroy(loveP1_1.gameObject);
                    }
                // if (isLocalPlayer)
                // {
                
                // if (isServer )
                // {
                //     if (other.gameObject.tag == "Gaco" && player.giliran == true)
                //     {
                //         Debug.Log("Anda Mati");
                //         Destroy(loveP1_1.gameObject);
                //         lifeP1 = true;
                //     }
                    
                // }
                // if (isClient){
                //     if (other.gameObject.tag == "Gaco" && player.giliran == true)
                //     {
                //         Debug.Log("Anda Mati");
                //         Destroy(loveP2_1.gameObject);
                //         lifeP1 = true;
                //     }
                // }
                // }
            }
     


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

        // if (isLocalPlayer)
        //     {
                
        //         if (isServer )
        //         {
        //             ball_1_TR.position = ball_1_Rb.position;
        //             transform.position = ball_1_TR.position;
                    
        //         }
        //         if (isClient)
        //         {
        //             ball_2_TR.position = ball_2_Rb.position;
        //             transform.position = ball_2_TR.position;
        //         }
        //     }
        
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
