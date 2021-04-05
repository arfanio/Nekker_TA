using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lemparanStart : MonoBehaviour
{
    public GameObject kelereng;
    public GameObject playerCamera;

    public float jarakKelereng = 1f;
    public float tembakBola = 5f;

    private bool pegangKelereng = true;
    void Start()
    {
        kelereng.GetComponent<Rigidbody> ().useGravity = false;
    }

    // Update is called once per frame
    void Update()
    { if (pegangKelereng) {
        kelereng.transform.position = playerCamera.transform.position + playerCamera.transform.forward * jarakKelereng;

        if (Input.GetMouseButtonDown(0)) {
            pegangKelereng = false;
            kelereng.GetComponent<Rigidbody> ().useGravity = true;
            kelereng.GetComponent<Rigidbody> ().AddForce (playerCamera.transform.forward * tembakBola);
        }
    }
    }
}
