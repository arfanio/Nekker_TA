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
    public static bool endP1 = false;
    public static bool endP2 = false;
    public static bool endedP1 = false;
    public static bool endedP2 = false;
    public static bool diamDiPot = true;
    public GameObject Gameover;
    public GameObject loveP1_1;
    // public GameObject loveP1_2;
    public GameObject loveP2_1;
    // public GameObject loveP2_2;
    

    void OnTriggerEnter (Collider other)
            {

                // if (other.gameObject.tag == "Gaco"){
                //     diamDiPot = false;
                //     Debug.Log("diam di pot "+ diamDiPot);
                // }
                if (other.gameObject.tag == "Gaco" && player.giliranMainP1 == true && player.giliran == true )
                    {
                        // Debug.Log("diam di pot setelah diolah "+ diamDiPot);
                        // if(diamDiPot == true){
                            endP1 = true;
                            endedP1 = true;
                            Debug.Log("Server P1 Mati");
                            Debug.Log("endP1");
                            player.giliranMainP2 = true;
                            player.giliranMainP1 = false;
                            player.giliranP1 = false;
                            // player.giliranP2 = true;
                            Debug.Log( "giliranMainP2 " + player.giliranMainP2);
                            Destroy(loveP1_1.gameObject);
                        // }
                    }

                if (other.gameObject.tag == "Gaco" && player.giliranMainP2 == true && player.giliran == true )
                    {
                        endP2 = true;
                        endedP2 = true;
                        Debug.Log("Client P2 Mati");
                        Debug.Log("endP2");
                        player.giliranMainP1 = true;
                        player.giliranMainP2 = false;
                        player.giliranP2 = false;
                        // player.giliranP1 = true;
                        Debug.Log("giliranMainP1 " + player.giliranMainP1);
                        Destroy(loveP2_1.gameObject);
                    }
            }

// IEnumerator your_timerPot() 
//     {
//         diamDiPot = false;
//         // Debug.Log("waktu p1" + Time.time);
//         yield return new WaitForSeconds(5.0f);
//         diamDiPot = true;
//         // Debug.Log(giliran);
//     }

    void OnTriggerExit (Collider other)
    {
        if (other.gameObject.tag == "Ball" && player.giliranP1 == true && player.giliranP2 == false  )
        {
            scorePointP1 += 1;
            Debug.Log( "P1 Server point " + scorePointP1);
            // player.giliranMainP1 = true;
            // player.giliranMainP2 = false;
            Destroy (other.gameObject,2f);
        }

         if (other.gameObject.tag == "Ball" && player.giliranP2 == true && player.giliranP1 == false  )
        {
            scorePointP2 += 1;
            Debug.Log( "P2 client point " + scorePointP2);
            // player.giliranMainP2 = true;
            // player.giliranMainP1 = false;
            Destroy (other.gameObject,2f);
        }
       
    }
    void Update(){
        // if (diamDiPot == false){
        //     StartCoroutine(your_timerPot());
        //     }
    // Debug.Log("P1"+player.giliranMainP1 + " P2"+player.giliranMainP2);
        // if(isLocalPlayer){
        ScoreTextP1.text = "Score P1 = " + scorePointP1.ToString("F0") ;
        ScoreTextP2.text = "Score P2 = " + scorePointP2.ToString("F0") ;
        totalScorePoint = scorePointP1 + scorePointP2;
                if(totalScorePoint == MaxScore){
                save_point.simpan_skor();
                Gameover.SetActive(true);
                scorePointP1 = 0;
                scorePointP2 = 0;
                Debug.Log("ulangteross");
                // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        // }
    }
}
