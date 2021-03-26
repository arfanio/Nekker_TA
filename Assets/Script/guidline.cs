using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guidline : MonoBehaviour
{
    [Range(1, 5)]
    [SerializeField] private int _maxIterations = 3;
    [SerializeField] private float _maxDistance = 10f;
 
    private int _count;
    private LineRenderer _line;
 
    private void Start() {
        _line = GetComponent<LineRenderer>();
    }
 
    private void Update() {
        _count = 0;
        _line.SetVertexCount(1);
        _line.SetPosition(0, transform.position);
        _line.enabled = RayCast(new Ray(transform.position, transform.forward));
    }
 
    private bool RayCast(Ray ray) {
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, _maxDistance) && _count <= _maxIterations - 1) {
            _count++;
            var reflectAngle = Vector3.Reflect(ray.direction, hit.normal);
            _line.SetVertexCount(_count + 1);
            _line.SetPosition(_count, hit.point);
            RayCast(new Ray(hit.point, reflectAngle));
            return true;
        }
        _line.SetVertexCount(_count + 2);
        _line.SetPosition(_count + 1, ray.GetPoint(_maxDistance));
        return false;
    }
}