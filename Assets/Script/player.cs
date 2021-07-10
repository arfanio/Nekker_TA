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
    public float ball_id;
    public Rigidbody ball_1;
    public float rotationSpeedP1 = 2.0f;
    public float rotationSpeedP2 = 0.4f;
    public float shootPower = 0.0f;
    public static bool giliran = true;
    public static bool giliranP1 = false;
    public static bool giliranP2 = false;
    public GameObject mainCamera;
    public GameObject power;
    public GameObject target;
    public LineRenderer guideline;
    Vector3 posisiAwal;

    void Start(){
        Vector3 posisiAwal = ball_1.position;
    }

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
                        giliranP1 = true;
                        if (potAreaNET.lifeP1 == true){
                            Debug.Log("server lifeP1" + potAreaNET.lifeP1);
                        }
                        
                        // Debug.Log("giliran Server " + giliranP1 +" dan yang Client " + giliranP2);
                    }
                    Debug.Log("ini server");
                    aimViewP1();
                    mainCamera.gameObject.SetActive(true);
                }

                if (isClientOnly)
                {
                    if (giliran == false){
                        StartCoroutine(your_timer());
                        power.gameObject.SetActive(false);
                    }

                    if (giliran == true){
                        power.gameObject.SetActive(true);
                        giliranP2 = true;
                        if (potAreaNET.lifeP2 == true){
                            Debug.Log("server lifeP2" + potAreaNET.lifeP2);
                        }
                        
                        // Debug.Log("giliran Client " + giliranP2 +" dan yang Server " + giliranP1);
                    }
                    Debug.Log("ini client");
                    aimViewP2();
                    mainCamera.gameObject.SetActive(true);
                    // Debug.Log(posisiAwal);
                }
            }
        }

    public void aimViewP1()
        {
            if (isLocalPlayer){
                if(potAreaNET.lifeP1 == true){
                    resetPosisi();
                    // transform.position = posisiAwal;
                
                        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) || Input.GetMouseButton(0) )
                        {
                                xRot += Input.GetAxis("Mouse X") * rotationSpeedP1;
                                yRot += Input.GetAxis("Mouse Y") * rotationSpeedP1;
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
                        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) || Input.GetMouseButtonUp(0))
                            {
                                // Debug.Log("Seharusnya Button Hilang");
                                guideline.gameObject.SetActive(false);
                            }
                }
                if(potAreaNET.lifeP1 == false)
                {
                    transform.position = ball_1.position;
                
                        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) || Input.GetMouseButton(0) )
                        {
                                xRot += Input.GetAxis("Mouse X") * rotationSpeedP1;
                                yRot += Input.GetAxis("Mouse Y") * rotationSpeedP1;
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
                        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) || Input.GetMouseButtonUp(0))
                            {
                                // Debug.Log("Seharusnya Button Hilang");
                                guideline.gameObject.SetActive(false);
                            }
                        }

            }
        }

        public void aimViewP2()
        {
            if (isLocalPlayer){
                if(potAreaNET.lifeP2 == true){
                    resetPosisi();
                    // transform.position = posisiAwal;
                
                        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) || Input.GetMouseButton(0) )
                        {
                                xRot += Input.GetAxis("Mouse X") * rotationSpeedP2;
                                yRot += Input.GetAxis("Mouse Y") * rotationSpeedP2;
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
                        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) || Input.GetMouseButtonUp(0))
                            {
                                // Debug.Log("Seharusnya Button Hilang");
                                guideline.gameObject.SetActive(false);
                            }
                }
                if(potAreaNET.lifeP2 == false)
                {
                    transform.position = ball_1.position;
                
                        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) || Input.GetMouseButton(0) )
                        {
                                xRot += Input.GetAxis("Mouse X") * rotationSpeedP2;
                                yRot += Input.GetAxis("Mouse Y") * rotationSpeedP2;
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
                        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) || Input.GetMouseButtonUp(0))
                            {
                                // Debug.Log("Seharusnya Button Hilang");
                                guideline.gameObject.SetActive(false);
                            }
                        }

            }
        }

    IEnumerator your_timer() 
    {
        giliran = false;
        // Debug.Log("waktu p1" + Time.time);
        yield return new WaitForSeconds(6.0f);
        giliran = true;
        // Debug.Log(giliran);
    }

    // IEnumerator your_timerP2() 
    // {
    //     giliranP2 = false;
    //     Debug.Log("waktu p2" + Time.time);
    //     yield return new WaitForSeconds(6.0f);
    //     giliranP2 = true;
    //     // Debug.Log(giliran);
    // }

    public void resetPosisi()
        {
                ball_1.transform.position = posisiAwal;
                // Vector3 posisiAwal = ball_1.position;
        }
        
    public void shoot()
        {
            // if(isLocalPlayer){
            //     if(isServer){
            //         nilaiGauge = powerUp.amtPower;
            //         giliranP1 = false;
            //         Debug.Log("P1" + giliranP1);
            //         pressShootP1 ();
            //     }
            //     if(isClient){
            //         nilaiGauge = powerUp.amtPower;
            //         giliranP2 = false;
            //         Debug.Log("P2" + giliranP2);
            //         pressShootP2 ();
            //     }
            // }

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
        // if(isLocalPlayer){
        //     if(isServer){
        //         if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) || Input.GetMouseButtonUp(0))
        //     {
        //         transform.position = ball_1.position;
        //         shootPower = nilaiGauge;
        //         ball_1.velocity = transform.forward * shootPower / 5.0f;
        //         giliranP1 = false;
        //         guideline.gameObject.SetActive(false);
        //     }
        //     }
        //     if(isClient){
        //         if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) || Input.GetMouseButtonUp(0))
        //     {
        //         transform.position = ball_1.position;
        //         shootPower = nilaiGauge;
        //         ball_1.velocity = transform.forward * shootPower / 5.0f;
        //         giliranP2 = false;
        //         guideline.gameObject.SetActive(false);
        //     }
        // }
            if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) || Input.GetMouseButtonUp(0))
            {
                transform.position = ball_1.position;
                shootPower = nilaiGauge;
                ball_1.velocity = transform.forward * shootPower / 5.0f;
                giliran = false;
                guideline.gameObject.SetActive(false);
            }
    }

    //  void pressShootP2()
    // {
    //     // if(isLocalPlayer){
    //     //     if(isServer){
    //     //         if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) || Input.GetMouseButtonUp(0))
    //     //     {
    //     //         transform.position = ball_1.position;
    //     //         shootPower = nilaiGauge;
    //     //         ball_1.velocity = transform.forward * shootPower / 5.0f;
    //     //         giliranP1 = false;
    //     //         guideline.gameObject.SetActive(false);
    //     //     }
    //     //     }
    //     //     if(isClient){
    //     //         if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) || Input.GetMouseButtonUp(0))
    //     //     {
    //     //         transform.position = ball_1.position;
    //     //         shootPower = nilaiGauge;
    //     //         ball_1.velocity = transform.forward * shootPower / 5.0f;
    //     //         giliranP2 = false;
    //     //         guideline.gameObject.SetActive(false);
    //     //     }
    //     // }
    //         if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) || Input.GetMouseButtonUp(0))
    //         {
    //             transform.position = ball_1.position;
    //             shootPower = nilaiGauge;
    //             ball_1.velocity = transform.forward * shootPower / 5.0f;
    //             giliranP2 = false;
    //             guideline.gameObject.SetActive(false);
    //         }
    // }

}
