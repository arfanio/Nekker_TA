using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopManagerScript : MonoBehaviour
{

    public int[,] shopItems = new int[5,5];
    public static int coins, coinsADD;
    public static int statpem1, statpem2, statpem3, statpem4 ;
    public int Id_gaco;
    public Text CoinsTXT;

    // void Start(){
    //     coinsADD = 1000;
    //     PlayerPrefs.SetInt("poin", coinsADD);
    // }

    void Update()
    {
        coins = PlayerPrefs.GetInt ("poin");
        statpem1 = PlayerPrefs.GetInt ("statpem1");
        statpem2 = PlayerPrefs.GetInt ("statpem2");
        statpem3 = PlayerPrefs.GetInt ("statpem3");
        statpem4 = PlayerPrefs.GetInt ("statpem4");
        // Id_gaco = 0;
        CoinsTXT.text = "Koin:" + coins.ToString();

        //ID's
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;

        //Price
        shopItems[2, 1] = 10;
        shopItems[2, 2] = 40;
        shopItems[2, 3] = 75;
        shopItems[2, 4] = 100;

        //Status Pembelian
        shopItems[3, 1] = statpem1;
        shopItems[3, 2] = statpem2;
        shopItems[3, 3] = statpem3;
        shopItems[3, 4] = statpem4;

        Debug.Log("ID 1 " + shopItems[3, 1]);
        Debug.Log("ID 2 " + shopItems[3, 2]);
        Debug.Log("ID 3 " + shopItems[3, 3]);
        Debug.Log("ID 4 " + shopItems[3, 4]);

    }

    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        if (coins >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            coins -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID]=1;

            if (shopItems[3, 1] != 0){
                statpem1 = 1;
                PlayerPrefs.SetInt("statpem1", statpem1 );
            }
            if (shopItems[3, 2] != 0){
                statpem2 = 1;
                PlayerPrefs.SetInt("statpem2", statpem2 );
            }
            if (shopItems[3, 3] != 0){
                statpem3 = 1;
                PlayerPrefs.SetInt("statpem3", statpem3 );
            }
            if (shopItems[3, 4] != 0){
                statpem4 = 1;
                PlayerPrefs.SetInt("statpem4", statpem4 );
            }

            CoinsTXT.text = "Koin:" + coins.ToString();
            ButtonRef.GetComponent<ButtonInfo>().QuantityTxt.text = shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
            PlayerPrefs.SetInt("poin", coins);
        }


    }

    public void Pakai()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        Id_gaco = shopItems[1, ButtonRef.GetComponent<ButtonInfoPemasangan>().ItemIDPasang];
        PlayerPrefs.SetInt("id_gaco", Id_gaco);
        Debug.Log(Id_gaco);
    }






    //     if (shopItems[4, ButtonRef.GetComponent<ButtonInfo>().ItemID] == 1);
    //     {
    //         Id_gaco = 1;
    //         PlayerPrefs.SetInt("id_gaco", Id_gaco);
    //         Debug.Log(Id_gaco);
    //     }
    //     if (shopItems[1, ButtonRef.GetComponent<ButtonInfo>().ItemID] == 2);
    //     {
    //         Id_gaco = 1;
    //         PlayerPrefs.SetInt("id_gaco", Id_gaco);
    //         Debug.Log(Id_gaco);
    //     }
    

}
