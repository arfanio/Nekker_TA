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
    // public bool ballStop;

    public int ball_id;
    public Rigidbody ball_1;
    public Rigidbody ball_2;
    public Rigidbody ball_3;
    public Rigidbody ball_4;

    private Transform startPOS;
    public static Vector3 posisiAwal;

    public float rotationSpeed = 0.2f;
    // private float shootPower = 0.1f;
    public float shootPower = 0.0f;

    public LineRenderer guideline;
    // public powerUp first;

        void Awake(){
            // startPOS = ball_2.transform;
            posisiAwal = ball_2.position;
        }
    
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

                // startPOS = ball_2.transform;
                // posisiAwal = startPOS.position;
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
            
            // if (ball_id == 2){
                // transform.position = ball_2.position;
                
                // if (transform.hasChanged){
                //     Debug.Log("udah false");
                //     shootButton.gameObject.SetActive(true);
                //     aimView();
                //     transform.hasChanged = false;
                // }
                // else {
                //     shootButton.gameObject.SetActive(false);
                //     Debug.Log("udah else");
                //     aimView();
                //     transform.hasChanged = false;

                // }
            
                
            // else{
            //     shootButton.gameObject.SetActive(false);
                
            // }
        //     speed = ball_2.velocity.magnitude;
        //     if(speed < 0.5) {
        //         ball_2.rigidbody.velocity = new Vector3(0, 0, 0);
        //         ballStop = true;
        //         //Or
        //     //     gameObject.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
        //     // }
        //     if(speed >= 0.5) {
        //         ball_2.rigidbody.velocity = new Vector3(0, 0, 0);
        //         ballStop = false;
        //     }
        // }
        }
        
    public void aimView()
        {
                
            if (ball_id == 0){
                transform.position = ball_1.position;
                // Vector3 posisiAwal = ball_1.position;
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
                
                if (Input.GetMouseButtonUp(0))
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
                
                if (Input.GetMouseButtonUp(0))
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
                
                if (Input.GetMouseButtonUp(0))
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
                
                if (Input.GetMouseButtonUp(0))
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
                
                if (Input.GetMouseButtonUp(0))
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
            // transform.position = ball_2.position;
            // if (transform.hasChanged){
                nilaiGauge = powerUp.amtPower;
                Debug.Log(nilaiGauge);
                // transform.hasChanged = false;
                pressShoot ();
            // }
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
            shootButton.gameObject.SetActive(false);
            Debug.Log("sampai presshoot dan seharusnya hilang");
            
        }
    }

}
