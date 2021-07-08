using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follower : MonoBehaviour
{
    public Transform targetObject;

    public Vector3 cameraOffset;

    public float smoothFactor = 0.5f;

    public bool lookAtTarget = false;

    public bool RotateAroundPlayer = true;

    public float RotationSpeed = 5.0f;

    void Start()
    {
        cameraOffset = transform.position - targetObject.transform.position;

    }

    void LateUpdate()
    {
        if(RotateAroundPlayer)
        {
            Quaternion camTurnAngle =
                Quaternion.AngleAxis(Input.GetAxis("Mouse x") * RotationSpeed, Vector3.up);

                cameraOffset = camTurnAngle * cameraOffset;
        }

        Vector3 newPosition = targetObject.transform.position + cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPosition, smoothFactor);

        if (lookAtTarget || RotateAroundPlayer)
        {
            transform.LookAt(targetObject);
        }
    }
}
