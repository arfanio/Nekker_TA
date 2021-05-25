using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class controllPoint : MonoBehaviour
{
    [SerializeField]
    private Button shootButton;
    // [SerializeField]
    // private Text textPowerAmt;
    public static float nilaiGauge ;

    float xRot, yRot = 0f;

    public Rigidbody ball;

    public float rotationSpeed = 5f;
    // private float shootPower = 0.1f;
    public float shootPower = 0.0f;

    public LineRenderer guideline;
    // public powerUp first;

void Update ()
    {
        transform.position = ball.position;
        if (Input.GetMouseButton(0))
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
        if (Input.GetMouseButtonUp(0))
        {
            // shootPower =textPowerAmt;
            // textPowerAmt.text = shootPower.ToString("F0");
            shootPower = nilaiGauge;
            ball.velocity = transform.forward * shootPower / 5.0f;
            guideline.gameObject.SetActive(false);
        }
    }

}
