using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
   public void ulangiClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void backmenuClicked()
    {
        
    }
}
