using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class gameOverNET : MonoBehaviour

{

GameObject Panel;


    public void backmenuClicked()
    {
        Application.LoadLevel(1);
        PhotonNetwork.Disconnect();
        Debug.Log("Disconnect From Server");
        Panel = GameObject.Find("PanelGameover");
        //Panel.gameObject.SetActive(false);
        
        Debug.Log("Hilanggg");
    }
}
