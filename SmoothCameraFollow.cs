using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{
    private Vector3 _offset;
    [SerializeField] private Transform target;
    [SerializeField] private float smoothTime;
    private Vector3 _currentVelocity = Vector3.zero;
    // Start is called before the first frame update
    private void Awake()
    {
        _offset = transform.position - target.position;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        Vector3 targertPosition = target.position + _offset;
        transform.position = Vector3.SmoothDamp(current: transform.position, targertPosition, ref _currentVelocity, smoothTime);
    }
}
