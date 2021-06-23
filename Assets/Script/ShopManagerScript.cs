using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopManagerScript : MonoBehaviour
{

    public int[,] shopItems = new int[5,5];
    public static int coins;
    public int Id_gaco;
    public Text CoinsTXT;

    void Start()
    {
        coins = PlayerPrefs.GetInt ("poin");
        // Id_gaco = 0;
        CoinsTXT.text = "Koin:" + coins.ToString();

        //ID's
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;

        //Price
        shopItems[2, 1] = 10;
        shopItems[2, 2] = 20;
        shopItems[2, 3] = 30;
        shopItems[2, 4] = 40;

        //Status Pembelian
        shopItems[3, 1] = 0;
        shopItems[3, 2] = 0;
        shopItems[3, 3] = 0;
        shopItems[3, 4] = 0;

        // //Status Pemasangan
        // shopItems[4, 1] = 0;
        // shopItems[4, 2] = 0;
        // shopItems[4, 3] = 0;
        // shopItems[4, 4] = 0;

    }

   
    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        if (coins >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            coins -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID]=1;
            CoinsTXT.text = "Koin:" + coins.ToString();
            ButtonRef.GetComponent<ButtonInfo>().QuantityTxt.text = shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
            PlayerPrefs.SetInt("poin", coins);
        }


    }

    public void Pakai()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        Id_gaco = shopItems[1, ButtonRef.GetComponent<ButtonInfoPemasangan>().ItemIDPasang];
        // shopItems[4, ButtonRef.GetComponent<ButtonInfoPasang>().ItemID]=2;
        PlayerPrefs.SetInt("id_gaco", Id_gaco);
        Debug.Log(Id_gaco);

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

}
