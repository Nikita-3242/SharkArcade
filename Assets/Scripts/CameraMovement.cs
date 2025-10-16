using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject target;
    public float cameraSpeed = 0.02f;

    void FixedUpdate()
    {
        Vector3 tempPos = Vector3.Lerp(transform.position, target.transform.position, cameraSpeed);
        tempPos.z = -10;
        transform.position = tempPos;
    }
}
