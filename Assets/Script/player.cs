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
    public static int simpan_point_serverP1, point_lama_serverP1, update_pointP1;
    public static int simpan_point_clientP2, point_lama_clientP2, update_pointP2;
    public float rotationSpeed = 0.8f;
    public float shootPower = 0.0f;
    public static bool giliran = true;
    public static bool giliranMainP1 = true;
    public static bool giliranMainP2 = false;
    public static bool giliranReset = true;
    public static bool giliranP1 = false;
    public static bool giliranP2 = false;
    public static bool lemparanAwal = false;
    public GameObject mainCamera;
    public GameObject power;
    public GameObject target;
    public LineRenderer guideline;
    Vector3 posisiAwal;
    public Rigidbody ball_1;


    void Update ()
        {
            if (isLocalPlayer)
            {
                mainCamera.gameObject.SetActive(true);
                Debug.Log("giliranP1 " + giliranP1 + " giliranP2 " + giliranP2 + " giliranMainP1 " + giliranMainP1 + " giliranMainP2 " + giliranMainP2 +
                 " giliran "+giliran + " endP1 "+potAreaNET.endP1 + " endP2 "+potAreaNET.endP2);
// -----------------------------------------------------------------------------------------------------//                
                if (potAreaNET.endP1 == true){
                    if(isServer){
                        power.gameObject.SetActive(false);
                        resetPosisi1();
                    }
                    potAreaNET.endP1 = false;
                }

                if (potAreaNET.endP2 == true){
                    if(isClientOnly){
                        power.gameObject.SetActive(false);
                        resetPosisi2();
                    }
                    potAreaNET.endP2 = false;
                }
// -----------------------------------------------------------------------------------------------------//                


                    if (giliran == false){
                        StartCoroutine(your_timer());
                        power.gameObject.SetActive(false);
                    }
                    

                    if (giliran == true && giliranMainP1 == true ){
                        // power.gameObject.SetActive(true);
                        giliranP1 = true;
                        giliranP2 = false;
                        potAreaNET.endedP1 = false; 
                        if(isServer){
                            power.gameObject.SetActive(true);
                            aimView();
                        }
                    }

                    if (giliran == true && giliranMainP2 == true){
                        // power.gameObject.SetActive(true);
                        giliranP2 = true;
                        giliranP1 = false;
                        potAreaNET.endedP2 = false;
                        if(isClientOnly){
                            power.gameObject.SetActive(true);
                            aimView();
                        }
                    }
                    updatePoint();
                    //  if (giliran == true && giliranMainP1 == false && giliranP2 == false){
                    //      power.gameObject.SetActive(false);
                    //  }
                    //  if (giliran == true && giliranMainP2 == false && giliranP1 == false){
                    //      power.gameObject.SetActive(false);
                    // }
            }
        }
// -----------------------------------------------------------------------------------------------------//
    public void updatePoint()
        {
            if (isLocalPlayer){
                if (isServer){
                    simpan_point_serverP1 = PlayerPrefs.GetInt ("simpan_pointP1");
                    point_lama_serverP1 = PlayerPrefs.GetInt ("poin");
                    update_pointP1 = simpan_point_serverP1 + point_lama_serverP1;
                    PlayerPrefs.SetInt("poin", update_pointP1);
                }

                if(isClientOnly){
                    simpan_point_clientP2 = PlayerPrefs.GetInt ("simpan_pointP2");
                    point_lama_clientP2 = PlayerPrefs.GetInt ("poin");
                    update_pointP2 = simpan_point_clientP2 + point_lama_clientP2;
                    PlayerPrefs.SetInt("poin", update_pointP2);
                }
            }
        }
// -----------------------------------------------------------------------------------------------------//
        public void aimView()
        {
            transform.position = ball_1.position;

            if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) || Input.GetMouseButton(0) )
                {
                    xRot += Input.GetAxis("Mouse X") * rotationSpeed;
                    yRot += Input.GetAxis("Mouse Y") * rotationSpeed;
                        if (yRot < -30f)
                        {
                            yRot = -30f;
                        }
                    transform.rotation = Quaternion.Euler(yRot, xRot, 0f);
                    giliranReset = false;
                    guideline.gameObject.SetActive(true);
                    guideline.SetPosition(0, transform.position);
                    guideline.SetPosition(1, transform.position + transform.forward * 4f);
                    }
            if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) || Input.GetMouseButtonUp(0))
                {
                    guideline.gameObject.SetActive(false);
                }
        }
// -----------------------------------------------------------------------------------------------------//
    IEnumerator your_timer() 
    {
        giliran = false;
        // Debug.Log("waktu p1" + Time.time);
        yield return new WaitForSeconds(8.0f);
        giliran = true;
        lemparanAwal = true;
        // Debug.Log(giliran);
    }
// -----------------------------------------------------------------------------------------------------//
    public void resetPosisi1()
        {
            ball_1.transform.position = new Vector3(-1.5f, 0.1f, -6.8f);
        }
// -----------------------------------------------------------------------------------------------------//
    public void resetPosisi2()
        {
            ball_1.transform.position = new Vector3(1.5f, 0.1f, -6.8f);
        }
// -----------------------------------------------------------------------------------------------------//        
    public void shoot()
        {
            nilaiGauge = powerUp.amtPower;
            Debug.Log(nilaiGauge);
            pressShoot ();
        }
// -----------------------------------------------------------------------------------------------------//
    void pressShoot()
    {
            if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) || Input.GetMouseButtonUp(0))
            {
                transform.position = ball_1.position;
                shootPower = nilaiGauge;
                ball_1.velocity = transform.forward * shootPower / 5.0f;
                giliran = false;
                guideline.gameObject.SetActive(false);
            }
    }
}
// -----------------------------------------------------------------------------------------------------//