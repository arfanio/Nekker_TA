using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFollow : MonoBehaviour
{
    public Transform PlayerTransform;

    private Vector3 _cameraOffset;

    [Range(0.01f, 1.0f)]
    public float smoothFactor = 0.5f;

    public bool LookAtPlayer = false;

    public bool RotateAroundPlayer = true;

    public float RotationSpeed = 5.0f;

    void Start ()
    {
        _cameraOffset = transform.position - PlayerTransform.position;
    }

    void LateUpdate ()
    {
        if(RotateAroundPlayer)
        {
            Quaternion canTurnAngle =
                Quaternion.AngleAxis(Input.GetAxis("Mouse x") * RotationSpeed, Vector3.up);

                _cameraOffset = canTurnAngle * _cameraOffset;
        }
        Vector3 newPos = PlayerTransform.position + _cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPos, smoothFactor);

        if (LookAtPlayer || RotateAroundPlayer)
            transform.LookAt(PlayerTransform);
    }
}
