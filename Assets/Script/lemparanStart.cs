using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lemparanStart : MonoBehaviour
{
    public GameObject kelereng;
    public GameObject playerCamera;

    public float jarakKelereng = 2f;
    public float tembakBola = 5f;

    private bool pegangKelereng = true;
    [Range(1, 5)]
    [SerializeField] private int _maxIterations = 3;
    [SerializeField] private float _maxDistance = 10f;
 
    private int _count;
    private LineRenderer _line;
    // Start is called before the first frame update
    void Start()
    {
        kelereng.GetComponent<Rigidbody> ().useGravity = false;
        _line = GetComponent<LineRenderer>();
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
