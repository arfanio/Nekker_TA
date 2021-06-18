using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class save_score : MonoBehaviour {
    public Text update_point_Text, input_point_Text ;
    public static int point_lama, olah_point, update_point;
	// Use this for initialization
	void Start () {
		input_point_Text.text = PlayerPrefs.GetInt ("poin").ToString ();
	}

	public void simpan_skor(){
        point_lama = potArea.scorePoint;
        olah_point = int.Parse(input_point_Text.text);
        update_point = point_lama + olah_point;
        PlayerPrefs.SetInt("poin", update_point);

		// PlayerPrefs.SetInt ("poin",int.Parse(input_point + point_lama));
	}
	
	// Update is called once per frame
	void Update () {
		// update_point = PlayerPrefs.GetInt ("poin").ToString ();
	}
}
