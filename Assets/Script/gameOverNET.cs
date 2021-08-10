using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameOverNET : MonoBehaviour

{

GameObject Network;


    public void backmenuClicked()
    {
        Application.LoadLevel(1);
        Network = GameObject.Find("NetworkManager");
        Network.gameObject.SetActive(false);
    }
}
