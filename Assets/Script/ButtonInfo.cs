using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{

    public int ItemID;
    public int quantity;
    public Text PriceTxt;
    public Text QuantityTxt;
    public GameObject ShopManager, buttonBeli;

    void Update()
    {
        PriceTxt.text = "" + ShopManager.GetComponent<ShopManagerScript>().shopItems[2, ItemID].ToString();
        quantity = ShopManager.GetComponent<ShopManagerScript>().shopItems[3, ItemID];
        if(quantity == 0 ){
            QuantityTxt.text = "Belum Dimiliki";
        }else{
            buttonBeli.SetActive(false);
            QuantityTxt.text = "Pakai";
        }
        
    }
}
