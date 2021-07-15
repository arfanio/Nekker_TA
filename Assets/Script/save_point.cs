using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class save_point : MonoBehaviour {
    public Text input_point_Text ;
    public static int point_lamaP1, point_lamaP2, olah_point, simpan_pointP1, simpan_pointP2;
	// public static int update_point = 0;
	// Use this for initialization
	// void Start () 
	// {
	// 	update_point = PlayerPrefs.GetInt ("poin");
	// }

	public static void simpan_skor(){
        point_lamaP1 = potAreaNET.scorePointP1;
        point_lamaP1 = potAreaNET.scorePointP2;
       
		
        simpan_pointP1 = point_lamaP1 ;
        simpan_pointP2 = point_lamaP2 ;
        PlayerPrefs.SetInt("simpan_pointP1", simpan_pointP1);
        PlayerPrefs.SetInt("simpan_pointP2", simpan_pointP2);
		// player.updatePoint();
		// Debug.Log(PlayerPrefs.GetInt ("poin"));
	}
	
	
	void Update () 
	{
		input_point_Text.text = "Total Poin = " + PlayerPrefs.GetInt ("poin").ToString("F0") ;
	}
}
