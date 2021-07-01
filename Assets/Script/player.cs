using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Mirror;

public class player : NetworkBehaviour
{
    public static float nilaiGauge ;
    float xRot, yRot = 0f;
    public int ball_id;
    public Rigidbody ball_1;
    public float rotationSpeed = 0.2f;
    public float shootPower = 0.0f;
    public GameObject mainCamera;
    public LineRenderer guideline;

    void Update ()
        {
            if (isLocalPlayer)
            {
                if (isServer )
                {
                    aimView();
                    mainCamera.gameObject.SetActive(true);
                }
                if (isClient)
                {
                    aimView();
                    mainCamera.gameObject.SetActive(true);
                }
            }
        }

    public void aimView()
        {
                transform.position = ball_1.position;
                // Vector3 posisiAwal = ball_1.position;
                if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) || Input.GetMouseButton(0) )
                {
                    xRot += Input.GetAxis("Mouse X") * rotationSpeed;
                    yRot += Input.GetAxis("Mouse Y") * rotationSpeed;
                    if (yRot < -35f)
                    {
                        yRot = -35f;
                    }
                    transform.rotation = Quaternion.Euler(yRot, xRot, 0f);
                    guideline.gameObject.SetActive(true);
                    guideline.SetPosition(0, transform.position);
                    guideline.SetPosition(1, transform.position + transform.forward * 4f);
                }
                if (Input.GetMouseButtonUp(0))
                    {
                        guideline.gameObject.SetActive(false);
                    }
        }
        
    public void shoot()
        {
            nilaiGauge = powerUp.amtPower;
            Debug.Log(nilaiGauge);
            pressShoot ();
            // nilaiGauge = amtPower;
            // int.TryParse(powerGauge, out nilaiGauge);
            // GameObject thePlayer = GameObject.Find("ThePlayer");
            // powerUp powerUp = thePlayer.GetComponent<powerUp>();
            // powerUp.amtPower = nilaiGauge;
            // first.powerGaugeClass();
        }

    void pressShoot()
    {
        if (isLocalPlayer){
            if (Input.GetMouseButtonUp(0))
            {
                shootPower = nilaiGauge;
                ball_1.velocity = transform.forward * shootPower / 5.0f;
                guideline.gameObject.SetActive(false);            
            }
        }
        
    }

}
