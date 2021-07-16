using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class save_point : MonoBehaviour {
    public Text input_point_Text ;
    public static int point_lama, olah_point, simpan_point;
	public static int update_point = 0;
	// Use this for initialization
	void Start () 
	{
		update_point = PlayerPrefs.GetInt ("poin");
	}

	public static void simpan_skor(){
        point_lama = potArea.scorePoint;
        simpan_point = point_lama + update_point;
        PlayerPrefs.SetInt("simpan_pointP1", simpan_point);
		Debug.Log(PlayerPrefs.GetInt ("poin"));
	}
}
