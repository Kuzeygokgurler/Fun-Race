using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 2, 5);

    private Transform cameraTransform;
    
    
    void Start()
    {
        cameraTransform = transform;
    }

    
    void LateUpdate()
    {
        cameraTransform.position = target.position + (target.rotation * offset);
        cameraTransform.LookAt(target);
    }
}
