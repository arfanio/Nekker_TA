using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Mirror;

public class potAreaNET : NetworkBehaviour
{
    // public static int scorePointP1 = 0;
    public static int penguranganScorePoint = 0;
    public static int totalScorePoint = 0;
    public Text totalScorePointText;
    // public Text ScoreTextP2;
    public int MaxScore;
    public GameObject Gameover;

    void OnTriggerExit (Collider other)
    {
        if (other.gameObject.tag == "Ball" )
        {
            totalScorePoint += 1;
            Debug.Log( "P1 Server point " + totalScorePoint);
            Destroy (other.gameObject,2f);
        }
    }
    void Update(){
        // if (diamDiPot == false){
        //     StartCoroutine(your_timerPot());
        //     }
    // Debug.Log("P1"+player.giliranMainP1 + " P2"+player.giliranMainP2);
        // if(isLocalPlayer){
        penguranganScorePoint = MaxScore - totalScorePoint;
        totalScorePointText.text = "Sisa Kelereng = " + penguranganScorePoint.ToString("F0") ;
                if(totalScorePoint == MaxScore){
                save_pointNET.simpan_skorNET();
                Gameover.SetActive(true);
                penguranganScorePoint = 0;
                Debug.Log("ulangteross");
                // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        // }
    }
}
