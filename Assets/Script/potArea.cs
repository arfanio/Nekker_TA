using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class potArea : MonoBehaviour
{
    public int scorePointP1 = 0;
    public int scorePointP2 = 0;
    public int scorePointAll = 0;
    public Text ScoreTextP1;
    public Text ScoreTextP2;
    public int MaxScore;
    public bool statplayer1;
    public bool statplayer2;
    public GameObject player1;
    public GameObject player2;
    public GameObject Gameover;
    // public Text ScoreText;

    void Start(){
        player1.SetActive(true);
        statplayer1 = true;
    }

    // Use this for initialization
    void Update(){
        
        if(statplayer1 == true){
            playGame1();
            pointPlayer1();
        }
        if(statplayer2 == true){
            playGame2();
            pointPlayer2();
        }
    }

    void playGame1()
    {
        player1.SetActive(true);
        statplayer1 = true;
        // player1 = true;
        playGame1.GetComponent<controllPoint>().shoot();
        // controllPoint scriptToAccess = playGame1.GetComponent<controllPoint>();
        // scriptToAccess.shoot();
    }

    void playGame2()
    {
        player2.SetActive(true);
        statplayer2 = true;
        // player1 = true;
        playGame2.GetComponent<controllPoint>().shoot();
        // controllPoint scriptToAccess = playGame1.GetComponent<controllPoint>();
        // scriptToAccess.shoot();
    }

    void pointPlayer1(){
        ScoreTextP1.text = "Score P1 = " + scorePointP1.ToString("F0") ;
        if(scorePointAll == MaxScore){
            Gameover.SetActive(true);
        }
    }

    void pointPlayer2(){
        ScoreTextP2.text = "Score P2 = " + scorePointP2.ToString("F0") ;
        if(scorePointAll == MaxScore){
            Gameover.SetActive(true);
        }
    }

    void OnTriggerExit (Collider other)
    {
        if(player1){
            if (other.gameObject.tag == "Ball")
            {
                scorePointP1 += 1;
                scorePointAll += 1;
                Destroy (other.gameObject,2f);
            }
        }
        else{
            if (other.gameObject.tag == "Ball")
            {
                scorePointP2 += 1;
                scorePointAll += 1;
                Destroy (other.gameObject,2f);
            }
        }
    }
}
