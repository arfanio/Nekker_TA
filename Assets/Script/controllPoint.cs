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

    public int ball_id;
    public Rigidbody ball_1;
    public Rigidbody ball_2;
    public Rigidbody ball_3;
    public Rigidbody ball_4;

    public float rotationSpeed = 0.2f;
    // private float shootPower = 0.1f;
    public float shootPower = 0.0f;

    public LineRenderer guideline;
    // public powerUp first;

        void Start ()
        {
            ball_id = PlayerPrefs.GetInt ("id_gaco");
            if (ball_id == 0)
            {
                ball_1.gameObject.SetActive(true);
                transform.position = ball_1.position;
            }
            if (ball_id == 1)
            {
                ball_1.gameObject.SetActive(true);
                transform.position = ball_1.position;
            }
            if (ball_id == 2)
            {
                ball_2.gameObject.SetActive(true);
                transform.position = ball_2.position;
            }
            if (ball_id == 3)
            {
                ball_3.gameObject.SetActive(true);
                transform.position = ball_3.position;
            }
            if (ball_id == 4)
            {
                ball_4.gameObject.SetActive(true);
                transform.position = ball_4.position;
            }
        }

    void Update ()
        {
            aimView();
            // Debug.Log(ball_id);
        }

    public void aimView()
        {
            // if (ball_id == 0){
            //     // Vector3 posisiAwal = ball_1.position;
            //     transform.position = ball_1.position;
                
            //     if (transform.rotation == ball_1.rotation){
            //         if (Input.touches.Length > 0){
            //             if ((Input.touches[0].phase == TouchPhase.Moved) )
            //             {
            //                 xRot += Input.GetAxis("Mouse X") * rotationSpeed;
            //                 yRot += Input.GetAxis("Mouse Y") * rotationSpeed;
            //                 if (yRot < -35f)
            //                 {
            //                     yRot = -35f;
            //                 }
            //                 transform.rotation = Quaternion.Euler(yRot, xRot, 0f);
            //                 guideline.gameObject.SetActive(true);
            //                 guideline.SetPosition(0, transform.position);
            //                 guideline.SetPosition(1, transform.position + transform.forward * 4f);
            //             }
            //         if (Input.GetMouseButtonUp(0))
            //             {
            //                 guideline.gameObject.SetActive(false);
            //             }
            //         }
            //     }
            //     }

            // if (ball_id == 1){
            //     // Vector3 posisiAwal = ball_1.position;
            //     transform.position = ball_1.position;
            //     if (transform.rotation == ball_1.rotation){
            //             if (Input.touches.Length > 0){
            //             if ((Input.touches[0].phase == TouchPhase.Moved) )
            //             {
            //                 xRot += Input.GetAxis("Mouse X") * rotationSpeed;
            //                 yRot += Input.GetAxis("Mouse Y") * rotationSpeed;
            //                 if (yRot < -35f)
            //                 {
            //                     yRot = -35f;
            //                 }
            //                 transform.rotation = Quaternion.Euler(yRot, xRot, 0f);
            //                 guideline.gameObject.SetActive(true);
            //                 guideline.SetPosition(0, transform.position);
            //                 guideline.SetPosition(1, transform.position + transform.forward * 4f);
            //             }
            //         if (Input.GetMouseButtonUp(0))
            //             {
            //                 guideline.gameObject.SetActive(false);
            //             }
            //         }
            //     }
            //     }
                
            if (ball_id == 0){
                transform.position = ball_1.position;
                // Vector3 posisiAwal = ball_1.position;
                if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) )
                {
                    xRot += Input.GetAxis("Mouse X") * rotationSpeed;
                    yRot += Input.GetAxis("Mouse Y") * rotationSpeed;
                    if (yRot < -30f)
                    {
                        yRot = -30f;
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

                if (ball_id == 1){
                transform.position = ball_1.position;
                // Vector3 posisiAwal = ball_1.position;
                if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) )
                {
                    xRot += Input.GetAxis("Mouse X") * rotationSpeed;
                    yRot += Input.GetAxis("Mouse Y") * rotationSpeed;
                    if (yRot < -30f)
                    {
                        yRot = -30f;
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

            if (ball_id == 2){
                transform.position = ball_2.position;
                // Vector3 posisiAwal = ball_2.position;
                if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved ))
                {
                    xRot += Input.GetAxis("Mouse X") * rotationSpeed;
                    yRot += Input.GetAxis("Mouse Y") * rotationSpeed;
                    if (yRot < -30f)
                    {
                        yRot = -30f;
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

                if (ball_id == 3){
                transform.position = ball_3.position;
                // Vector3 posisiAwal = ball_3.position;
                if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) )
                {
                    xRot += Input.GetAxis("Mouse X") * rotationSpeed;
                    yRot += Input.GetAxis("Mouse Y") * rotationSpeed;
                    if (yRot < -30f)
                    {
                        yRot = -30f;
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

                if (ball_id == 4){
                transform.position = ball_4.position;
                // Vector3 posisiAwal = ball_4.position;
                if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) )
                {
                    xRot += Input.GetAxis("Mouse X") * rotationSpeed;
                    yRot += Input.GetAxis("Mouse Y") * rotationSpeed;
                    if (yRot < -30f)
                    {
                        yRot = -30f;
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
            if (ball_id == 0)
            {
                ball_1.velocity = transform.forward * shootPower / 5.0f;
                guideline.gameObject.SetActive(false);
            }
            if (ball_id == 1)
            {
                ball_1.velocity = transform.forward * shootPower / 5.0f;
                guideline.gameObject.SetActive(false);
            }
            if (ball_id == 2)
            {
                ball_2.velocity = transform.forward * shootPower / 5.0f;
                guideline.gameObject.SetActive(false);
            }
            if (ball_id == 3)
            {
                ball_3.velocity = transform.forward * shootPower / 5.0f;
                guideline.gameObject.SetActive(false);
            }
            if (ball_id == 4)
            {
                ball_4.velocity = transform.forward * shootPower / 5.0f;
                guideline.gameObject.SetActive(false);
            }
            
        }
    }

}
