using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainMenu : MonoBehaviour
{
    public GameObject bg;
    public GameObject main;
    public GameObject about;
    // Start is called before the first frame update
    void Start()
    {
        bg.SetActive(true);
        main.SetActive(false);
        about.SetActive(false);
        
    }

    public void mainClicked()
    {
        bg.SetActive(false);
        main.SetActive(true);
        about.SetActive(false);
    }

    public void aboutClicked()
    {
        bg.SetActive(false);
        main.SetActive(false);
        about.SetActive(true);
    }

    public void exitClicked()
    {
        Application.Quit();
    }

    public void backClicked()
    {
        bg.SetActive(true);
        main.SetActive(false);
        about.SetActive(false);
    }

    public void sendiriClicked()
    {
        Application.LoadLevel("Lemparan Awal");
    }

}
