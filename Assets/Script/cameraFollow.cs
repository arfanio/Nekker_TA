using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    

    public LineRenderer guideline;
    public Transform targetObject;

    public Vector3 cameraOffset_1;
    public Vector3 cameraOffset_2;

    float xRot, yRot = 0f;

    public float smoothFactor = 0.5f ;

    public bool lookAtTarget = true;
    
    void Start()
    {
        cameraOffset_1 = transform.position - targetObject.transform.position;
    }

    void LateUpdate()
    {
        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) || Input.GetMouseButton(0) ){
            
            if (lookAtTarget)
            {
                xRot += Input.GetAxis("Mouse X") ;
                yRot += Input.GetAxis("Mouse Y") ;
                    if (yRot < -35f)
                    {
                        yRot = -35f;
                    }
                    transform.rotation = Quaternion.Euler(yRot, xRot, 0f);
                    guideline.gameObject.SetActive(true);
                    guideline.SetPosition(0, transform.position);
                    guideline.SetPosition(1, transform.position + transform.forward * 4f);
            }
            
        }
        else{
            tripod();
        }
        
    }

    public void tripod(){
        Vector3 newPosition = targetObject.transform.position + cameraOffset_1;
        transform.position = Vector3.Slerp(transform.position, newPosition,smoothFactor);
    
        if (lookAtTarget)
        {
            transform.LookAt(targetObject);
        }
    }
    
}
