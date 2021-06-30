using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainMenu : MonoBehaviour
{
    public GameObject bg;
    public GameObject main;
    public GameObject about;
    public GameObject shop;
    // Start is called before the first frame update
    void Start()
    {
        bg.SetActive(true);
        main.SetActive(false);
        about.SetActive(false);
        shop.SetActive(false);
        
    }

         public void playClicked()
    {
        bg.SetActive(false);
        main.SetActive(true);
        about.SetActive(false);
        shop.SetActive(false);
    }

        public void shopClicked()
    {
        bg.SetActive(false);
        main.SetActive(false);
        about.SetActive(false);
        shop.SetActive(true);
    }

    public void aboutClicked()
    {
        bg.SetActive(false);
        main.SetActive(false);
        about.SetActive(true);
        shop.SetActive(false);
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
        shop.SetActive(false);
    }

    public void multiplayerClicked()
    {
        Application.LoadLevel("LemparanAwal");
    }

    public void soloClicked()
    {
        Application.LoadLevel("SoloPlayer");
    }


}
