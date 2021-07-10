using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    [SerializeField]
    public GameObject player;
    public Vector3 offset;
 
    // Use this for initialization
    void Start () {
        offset = transform.position - player.transform.position;
    }
 
    void LateUpdate() {
        transform.position = player.transform.position + offset;
 
        transform.RotateAround(transform.parent.position, new Vector3(0,1,0),10*Time.deltaTime);
    }
}
