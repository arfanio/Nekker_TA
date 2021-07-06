using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Mirror;

public class powerUp : NetworkBehaviour
{
    [SerializeField]
    private Image imagePowerup;
    [SerializeField]
    private TMP_Text textPowerAmt;

    private bool isPowerUp = false;
    private bool isDirectionUp = true;
    public static float amtPower = 0.0f;
    private float powerSpeed = 100.0f;

    public float powerGauge;
    // Update is called once per frame
    void Update()
    {
        if(isPowerUp)
        {
            PowerActive();
        }
    }

    void PowerActive()
    {
        if(isDirectionUp)
        {
            amtPower += Time.deltaTime * powerSpeed;
            if(amtPower > 100)
            {
                isDirectionUp = false;
                amtPower = 100.0f;
            }
        }
        else
        {
            amtPower -= Time.deltaTime * powerSpeed;
            if(amtPower < 0)
            {
                isDirectionUp = true;
                amtPower = 0.0f;
            }
        }
        imagePowerup.fillAmount = (0.483f - 0.25f) * amtPower / 100.0f + 0.25f;
    }

    public void StartPowerUp()
    {
        isPowerUp = true;
        amtPower = 0.0f;
        isDirectionUp = true;
        textPowerAmt.text = "";
    }

    public void EndPowerUp()
    {
        isPowerUp = false;
        // powerGauge = amtPower;
        textPowerAmt.text = amtPower.ToString("F0");
        // Debug.Log(amtPower);
    }

    // public void powerGaugeClass()
    // {
    //     Debug.Log(amtPower);
    // }
}
