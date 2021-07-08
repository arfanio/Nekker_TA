using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Mirror;

public class player : NetworkBehaviour
{
    public static float nilaiGauge ;
    public static float xRot, yRot = 0f;
    public int delay;
    public float waktuBerjalan;
    public float ball_id;
    public Rigidbody ball_1;
    public float rotationSpeed = 0.2f;
    public float shootPower = 0.0f;
    public static bool giliran = true;
    public GameObject mainCamera;
    public GameObject power;
    public GameObject target;
    public LineRenderer guideline;

    void Update ()
        {
            if (isLocalPlayer)
            {
                
                if (isServer )
                {
                    if (giliran == false){
                        StartCoroutine(your_timer());
                        power.gameObject.SetActive(false);
                    }

                    if (giliran == true){
                        power.gameObject.SetActive(true);
                    }
                    aimViewP1();
                    mainCamera.gameObject.SetActive(true);
                }
                if (isClient)
                {
                    if (giliran == false){
                        StartCoroutine(your_timer());
                        power.gameObject.SetActive(false);
                    }

                    if (giliran == true){
                        power.gameObject.SetActive(true);
                    }
                    aimViewP1();
                    mainCamera.gameObject.SetActive(true);
                }
            }
        }

    public void aimViewP1()
        {
                transform.position = ball_1.position;
                // Vector3 posisiAwal = ball_1.position;
                if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) || Input.GetMouseButton(0) )
                {
                        xRot += Input.GetAxis("Mouse X") * rotationSpeed;
                        yRot += Input.GetAxis("Mouse Y") * rotationSpeed;
                        if (yRot < -30f)
                        {
                            yRot = -30f;
                        }
                        transform.rotation = Quaternion.Euler(yRot, xRot, 0f);
                        // if (transform.hasChanged ){
                        //     Debug.Log("jika bola terdiam muncula button");
                        //     // power.gameObject.SetActive(false);
                        //     // transform.hasChanged = false;
                        // }
                        
                        // transform.position = mainCamera.position;
                        // transform.RotateAround(transform.parent.position, new Vector3(0,1,0),10*Time.deltaTime);
                        
                        guideline.gameObject.SetActive(true);
                        guideline.SetPosition(0, transform.position);
                        guideline.SetPosition(1, transform.position + transform.forward * 4f);
                }
                if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) || Input.GetMouseButton(0))
                    {
                        // Debug.Log("Seharusnya Button Hilang");
                        guideline.gameObject.SetActive(true);
                        transform.hasChanged = false;
                    }
        }

    IEnumerator your_timer() 
    {
        giliran = false;
        Debug.Log("Your enter Coroutine at" + Time.time);
        yield return new WaitForSeconds(5.0f);
        giliran = true;
        // Debug.Log(giliran);
    }

    // public void aimViewP2()
    //     {
    //             transform.position = ball_1.position;
    //             // Vector3 posisiAwal = ball_1.position;
    //             if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) || Input.GetMouseButton(0) )
    //             {
    //                     xRot += Input.GetAxis("Mouse X") * rotationSpeed;
    //                     yRot += Input.GetAxis("Mouse Y") * rotationSpeed;
    //                     if (yRot < -30f)
    //                     {
    //                         yRot = -30f;
    //                     }
    //                     transform.rotation = Quaternion.Euler(yRot, xRot, 0f);
    //                     // ball_1.AddForce(transform);
    //                     if (transform.hasChanged){
    //                         Debug.Log("jika bola terdiam muncula button");
    //                         power.gameObject.SetActive(true);
    //                         transform.hasChanged = false;
    //                     }
                        
                        
    //                     guideline.gameObject.SetActive(true);
    //                     guideline.SetPosition(0, transform.position);
    //                     guideline.SetPosition(1, transform.position + transform.forward * 4f);
    //             }
    //             if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) || Input.GetMouseButtonUp(0))
    //                 {
    //                     Debug.Log("Seharusnya Button Hilang");
    //                     guideline.gameObject.SetActive(false);
    //                     transform.hasChanged = false;
    //                 }
    //     }
        
    public void shoot()
        {
            nilaiGauge = powerUp.amtPower;
            Debug.Log(nilaiGauge);
            pressShoot ();
            // if (Time.deltaTime == delay){
            //     giliran = true;
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
        
            if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) || Input.GetMouseButtonUp(0))
            {
                transform.position = ball_1.position;
                shootPower = nilaiGauge;
                ball_1.velocity = transform.forward * shootPower / 5.0f;
                guideline.gameObject.SetActive(false);
                giliran = false;
                // waktuBerjalan = Time.deltaTime;
                // Debug.Log(waktuBerjalan);

                // if (waktuBerjalan > delay ){
                //     giliran = true;
                //     waktuBerjalan = 0.0f;
                //     Debug.Log(giliran);
                //     Debug.Log(waktuBerjalan);
                // }

            }
        
        
    }

}
