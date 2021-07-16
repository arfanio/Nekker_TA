using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class save_pointNET : MonoBehaviour {
    public Text input_point_TextNET ;
    public static int point_lamaNET, olah_pointNET, simpan_pointNET;
	// public static int update_point = 0;
	// Use this for initialization
	// void Start () 
	// {
	// 	update_point = PlayerPrefs.GetInt ("poin");
	// }

	public static void simpan_skorNET(){
        point_lamaNET = potAreaNET.totalScorePoint;
        simpan_pointNET = point_lamaNET;
        PlayerPrefs.SetInt("poin", simpan_pointNET);
		Debug.Log(PlayerPrefs.GetInt ("poin"));
	}
}
