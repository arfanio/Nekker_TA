using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

using Photon.Pun;

public class player : MonoBehaviourPun
{
    public static float nilaiGauge ;
    public static float xRot, yRot = 0f;
    public float rotationSpeed = 0.8f;
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
    // void Start ()
    //     {
    //         if (photonView.IsMine)
    //         {
    //             aimView();
    //             mainCamera.gameObject.SetActive(true);
    //             // GetComponent<player>().enabled = true;
    //         }
    //     }

    //     public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    // {
    //     if (stream.IsWriting)
    //     {
    //         //We own this player: send the others our data
    //         stream.SendNext(transform.position);
    //     }
    //     else
    //     {
    //         //Network player, receive data
    //         ball_1 = (Vector3)stream.ReceiveNext();
    //         ball_1 = (Quaternion)stream.ReceiveNext();
    //     }
    // }
//-----------------------------------------------------------------------------------------------------//
    void Update ()
        {
            if (photonView.IsMine)
            {
                aimView();
                mainCamera.gameObject.SetActive(true);
            }
            // aimView();
            // mainCamera.gameObject.SetActive(true);

            if (photonView.IsMine == false && PhotonNetwork.IsConnected == true)
            {
                power.gameObject.SetActive(false);
                mainCamera.gameObject.SetActive(false);
                return;
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
        // if (photonView.IsMine)
        //     {
            if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) || Input.GetMouseButtonUp(0))
            {
                transform.position = ball_1.position;
                shootPower = nilaiGauge;
                ball_1.velocity = transform.forward * shootPower / 5.0f;
                giliran = false;
                guideline.gameObject.SetActive(false);
            }
            // }
            // return;    
    }
}
// -----------------------------------------------------------------------------------------------------//