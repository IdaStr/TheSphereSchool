using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float distance = 5.0f;  //how far from the target
    public float height = 3.0f;    // How high from the target

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //move the camera to the target, then back, then up
        transform.position = target.position - target.forward * distance + Vector3.up * height;

        //look at the target
        transform.LookAt(target);

    }
}
