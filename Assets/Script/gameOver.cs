using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour

{

    GameObject Panel;

   public void ulangiClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Panel = GameObject.Find("PanelGameover");
        Panel.gameObject.SetActive(false);
        Debug.Log("Hilanggg");

    }


    public void backmenuClicked()
    {
        Application.LoadLevel(1);
    }
}
