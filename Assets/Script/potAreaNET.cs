using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class potAreaNET : MonoBehaviour
{
    public static int penguranganScorePoint = 0;
    public static int totalScorePoint = 0;
    public Text totalScorePointText;
    public int MaxScore;
    public GameObject Gameover;

    void OnTriggerExit (Collider other)
    {
        if (other.gameObject.tag == "Ball" )
        {
            totalScorePoint += 1;
            Debug.Log( totalScorePoint);
            Destroy (other.gameObject,2f);
        }
    }
    void Update(){
        penguranganScorePoint = MaxScore - totalScorePoint;
        totalScorePointText.text = "Sisa Kelereng = " + penguranganScorePoint.ToString("F0") ;
                if(totalScorePoint == MaxScore){
                save_pointNET.simpan_skorNET();
                Gameover.SetActive(true);
                penguranganScorePoint = 0;
                // Debug.Log("ulangteross");
        }
    }
}
