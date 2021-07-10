using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    

    public LineRenderer guideline;
    public Transform targetObject;
    public GameObject power;

    public Vector3 cameraOffset_1;
    

    float xRot, yRot = 0f;
    public float rotationSpeed = 0.2f;

    public float smoothFactor = 0.5f ;

    public bool lookAtTarget = true;
    
    void Start()
    {
        cameraOffset_1 = transform.position - targetObject.transform.position;
    }

    void Update()
    {
        aimViewP1();
        // tripod();
    }

    public void aimViewP1()
        {
                transform.position = targetObject.position;
                // Vector3 posisiAwal = ball_1.position;
                if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) || Input.GetMouseButton(0) )
                {
                    // cameraOffset_1 = transform.position - targetObject.transform.position;
                        xRot += Input.GetAxis("Mouse X") * rotationSpeed;
                        yRot += Input.GetAxis("Mouse Y") * rotationSpeed;
                        if (yRot < -30f)
                        {
                            yRot = -30f;
                        }
                        transform.rotation = Quaternion.Euler(yRot, xRot, 0f);
                        
                        
                        if (transform.hasChanged){
                            Debug.Log("jika bola terdiam muncula button");
                            power.gameObject.SetActive(true);
                            transform.hasChanged = false;
                        }
                        
                        // transform.position = mainCamera.position;
                        // transform.RotateAround(transform.parent.position, new Vector3(0,1,0),10*Time.deltaTime);
                        
                        guideline.gameObject.SetActive(true);
                        guideline.SetPosition(0, transform.position);
                        guideline.SetPosition(1, transform.position + transform.forward * 4f);
                }
                if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) || Input.GetMouseButton(0))
                    {
                        Debug.Log("Seharusnya Button Hilang");
                        guideline.gameObject.SetActive(false);
                        transform.hasChanged = false;
                    }
        }

    public void tripod(){
        // transform.rotation = Quaternion.Euler(yRot, xRot, 0f);
        Vector3 newPosition = transform.position + cameraOffset_1;
        transform.position = Vector3.Slerp(transform.position, newPosition,smoothFactor);
    
        if (lookAtTarget)
        {
            transform.LookAt(targetObject);
        }
    }
    
}