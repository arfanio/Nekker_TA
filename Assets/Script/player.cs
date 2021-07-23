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
    public float rotationSpeed = 0.4f;
    public float shootPower = 0.0f;
    public static bool giliran = true;
    public GameObject mainCamera;
    public GameObject power;
    public GameObject target;
    GameObject NetworkStart;
    public LineRenderer guideline;
    Vector3 posisiAwal;
    public Rigidbody ball_1;

// -----------------------------------------------------------------------------------------------------//
    void Start ()
        {
        NetworkStart = GameObject.Find("NetworkManager");
        NetworkStart.gameObject.SetActive(true);
        }
// -----------------------------------------------------------------------------------------------------//
    void Update ()
        {
            if (isLocalPlayer)
            {
                    if (giliran == false){
                        StartCoroutine(your_timer());
                        power.gameObject.SetActive(false);
                    }

                    if (giliran == true ){
                        if(isServer){
                            mainCamera.gameObject.SetActive(true);
                            power.gameObject.SetActive(true);
                            aimView();
                        }
                        if(isClientOnly){
                            mainCamera.gameObject.SetActive(true);
                            power.gameObject.SetActive(true);
                            aimView();
                        }
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
    }
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