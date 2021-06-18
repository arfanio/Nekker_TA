using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class save_point : MonoBehaviour {
    public Text input_point_Text ;
    public static int point_lama, olah_point, simpan_point;
	public int update_point = 0;
	// Use this for initialization
	void Start () {
		update_point = PlayerPrefs.GetInt ("poin");
	}

	public void simpan_skor(){
        point_lama = potArea.scorePoint;
        olah_point = int.Parse(input_point_Text.text);
        simpan_point = point_lama + olah_point;
        PlayerPrefs.SetInt("poin", simpan_point);
		update_point = simpan_point;


		// PlayerPrefs.SetInt ("poin",int.Parse(input_point + point_lama));
	}
	
	// Update is called once per frame
	void Update () {
		// update_point = PlayerPrefs.GetInt ("poin").ToString ();
	}
}
