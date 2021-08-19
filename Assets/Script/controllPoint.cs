using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class controllPoint : MonoBehaviour
{
    [SerializeField]
    private GameObject shootButton;
    public static float nilaiGauge ;
    float xRot, yRot = 0f;
    float speed;
    public int ball_id;
    public Rigidbody ball_1;
    public Rigidbody ball_2;
    public Rigidbody ball_3;
    public Rigidbody ball_4;
    private Transform startPOS;
    public static Vector3 posisiAwal;
    float rotationSpeed = 0.8f;
    public float shootPower = 0.0f;
    public LineRenderer guideline;
        void Start ()
        {
            ball_id = PlayerPrefs.GetInt ("id_gaco");
            if (ball_id == 0)
            {
                ball_1.gameObject.SetActive(true);
            }
            if (ball_id == 1)
            {
                ball_1.gameObject.SetActive(true);
            }
            if (ball_id == 2)
            {
                ball_2.gameObject.SetActive(true);
            }
            if (ball_id == 3)
            {
                ball_3.gameObject.SetActive(true);
            }
            if (ball_id == 4)
            {
                ball_4.gameObject.SetActive(true);
            }
        }

    void Update ()
        {
            aimView();
        }
        
    public void aimView()
        {
                
            if (ball_id == 0){
                transform.position = ball_1.position;
                // Vector3 posisiAwal = ball_1.position;
                 if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved ))
                    {
                        xRot += Input.GetAxis("Mouse X") * rotationSpeed;
                        yRot += Input.GetAxis("Mouse Y") * rotationSpeed;
                        if (yRot < -30f)
                        {
                            yRot = -30f;
                        }
                        transform.rotation = Quaternion.Euler(yRot, xRot, 0f);
                        
                        if (transform.hasChanged){
                            Debug.Log("jika bola terdiam muncula button");
                            shootButton.gameObject.SetActive(true);
                            transform.hasChanged = false;
                        }
                        
                        guideline.gameObject.SetActive(true);
                        guideline.SetPosition(0, transform.position);
                        guideline.SetPosition(1, transform.position + transform.forward * 4f);
                    }
                // }
                
                if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended ))
                    {
                        // shootButton.gameObject.SetActive(false);
                        Debug.Log("Seharusnya Button Hilang");
                        guideline.gameObject.SetActive(false);
                        transform.hasChanged = false;
                    }
                }

                if (ball_id == 1){
                transform.position = ball_1.position;
                // Vector3 posisiAwal = ball_1.position;
                 if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved ))
                    {
                        xRot += Input.GetAxis("Mouse X") * rotationSpeed;
                        yRot += Input.GetAxis("Mouse Y") * rotationSpeed;
                        if (yRot < -30f)
                        {
                            yRot = -30f;
                        }
                        transform.rotation = Quaternion.Euler(yRot, xRot, 0f);
                        
                        if (transform.hasChanged){
                            Debug.Log("jika bola terdiam muncula button");
                            shootButton.gameObject.SetActive(true);
                            transform.hasChanged = false;
                        }
                        
                        guideline.gameObject.SetActive(true);
                        guideline.SetPosition(0, transform.position);
                        guideline.SetPosition(1, transform.position + transform.forward * 4f);
                    }
                // }
                
                if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended ))
                    {
                        // shootButton.gameObject.SetActive(false);
                        Debug.Log("Seharusnya Button Hilang");
                        guideline.gameObject.SetActive(false);
                        transform.hasChanged = false;
                    }
                }

            if (ball_id == 2 ){
                transform.position = ball_2.position;
                // shootButton.gameObject.SetActive(true);
                // Vector3 posisiAwal = ball_2.position;
                // if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved || Input.GetMouseButton(0) && transform.hasChanged ))
                // if (transform.hasChanged){
                    if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved))
                    {
                        xRot += Input.GetAxis("Mouse X") * rotationSpeed;
                        yRot += Input.GetAxis("Mouse Y") * rotationSpeed;
                        if (yRot < -30f)
                        {
                            yRot = -30f;
                        }
                        transform.rotation = Quaternion.Euler(yRot, xRot, 0f);
                        
                        if (transform.hasChanged){
                            Debug.Log("jika bola terdiam muncula button");
                            shootButton.gameObject.SetActive(true);
                            transform.hasChanged = false;
                        }
                        
                        guideline.gameObject.SetActive(true);
                        guideline.SetPosition(0, transform.position);
                        guideline.SetPosition(1, transform.position + transform.forward * 4f);
                    }
                // }
                
                if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended ))
                    {
                        // shootButton.gameObject.SetActive(false);
                        Debug.Log("Seharusnya Button Hilang");
                        guideline.gameObject.SetActive(false);
                        transform.hasChanged = false;
                    }
                }

                if (ball_id == 3){
                transform.position = ball_3.position;
                // Vector3 posisiAwal = ball_3.position;
                 if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved))
                    {
                        xRot += Input.GetAxis("Mouse X") * rotationSpeed;
                        yRot += Input.GetAxis("Mouse Y") * rotationSpeed;
                        if (yRot < -30f)
                        {
                            yRot = -30f;
                        }
                        transform.rotation = Quaternion.Euler(yRot, xRot, 0f);
                        
                        if (transform.hasChanged){
                            Debug.Log("jika bola terdiam muncula button");
                            shootButton.gameObject.SetActive(true);
                            transform.hasChanged = false;
                        }
                        
                        guideline.gameObject.SetActive(true);
                        guideline.SetPosition(0, transform.position);
                        guideline.SetPosition(1, transform.position + transform.forward * 4f);
                    }
                // }
                
                if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended ))
                    {
                        // shootButton.gameObject.SetActive(false);
                        Debug.Log("Seharusnya Button Hilang");
                        guideline.gameObject.SetActive(false);
                        transform.hasChanged = false;
                    }
                }

                if (ball_id == 4){
                transform.position = ball_4.position;
                // Vector3 posisiAwal = ball_4.position;
                 if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved))
                    {
                        xRot += Input.GetAxis("Mouse X") * rotationSpeed;
                        yRot += Input.GetAxis("Mouse Y") * rotationSpeed;
                        if (yRot < -30f)
                        {
                            yRot = -30f;
                        }
                        transform.rotation = Quaternion.Euler(yRot, xRot, 0f);
                        
                        if (transform.hasChanged){
                            Debug.Log("jika bola terdiam muncula button");
                            shootButton.gameObject.SetActive(true);
                            transform.hasChanged = false;
                        }
                        
                        guideline.gameObject.SetActive(true);
                        guideline.SetPosition(0, transform.position);
                        guideline.SetPosition(1, transform.position + transform.forward * 4f);
                    }
                // }
                
                if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended ))
                    {
                        // shootButton.gameObject.SetActive(false);
                        Debug.Log("Seharusnya Button Hilang");
                        guideline.gameObject.SetActive(false);
                        transform.hasChanged = false;
                    }
                }
        }
        
    public void shoot()
        {
                nilaiGauge = powerUp.amtPower;
                Debug.Log(nilaiGauge);
                pressShoot ();
        }

    void pressShoot()
    {
        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended ))
        {
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
            shootButton.gameObject.SetActive(false);
            Debug.Log("sampai presshoot dan seharusnya hilang");
            
        }
    }

}
