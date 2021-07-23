using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class follower : MonoBehaviour
{
    public Transform targetObject;

    public Vector3 cameraOffset;

    public float smoothFactor = 0.5f;

    public bool lookAtTarget = false;

    public bool RotateAroundPlayer = true;

    public float RotationSpeed = 0.8f;

    void Start()
    {
        // if(isLocalPlayer){
        //     if(isServer){
        //         cameraOffset = transform.position - targetObject.transform.position;
        //     }
        //     if(isClient){
        //         cameraOffset = transform.position - targetObject.transform.position;
        //     }
            cameraOffset = transform.position - targetObject.transform.position;
        // }
    }

    void LateUpdate()
    {
        // if (isLocalPlayer)
        //     {
        //         if (isServer )
        //         {
                   if(RotateAroundPlayer)
                    {
                        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) || Input.GetMouseButton(0) ){
                            Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * RotationSpeed, Vector3.up);

                            cameraOffset = camTurnAngle * cameraOffset;
                        }
                    
                    }

                    Vector3 newPosition = targetObject.transform.position + cameraOffset;
                    transform.position = Vector3.Slerp(transform.position, newPosition, smoothFactor);

                    if (lookAtTarget && RotateAroundPlayer)
                    {
                        transform.LookAt(targetObject);
                    }
                // }

            //     if (isClient)
            //     {
            //         if(RotateAroundPlayer)
            //         {
            //             if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) || Input.GetMouseButton(0) ){
            //                 Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * RotationSpeed, Vector3.up);

            //                 cameraOffset = camTurnAngle * cameraOffset;
            //             }
                    
            //         }

            //         Vector3 newPosition = targetObject.transform.position + cameraOffset;
            //         transform.position = Vector3.Slerp(transform.position, newPosition, smoothFactor);

            //         if (lookAtTarget && RotateAroundPlayer)
            //         {
            //             transform.LookAt(targetObject);
            //         }
            //     }
            // }
        
    }
}
