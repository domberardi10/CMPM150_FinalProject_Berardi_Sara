using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform pivotObject;
    public float rotationAngle = 15f;

    void Update()
    {
        transform.RotateAround(pivotObject.transform.position, Vector3.up, rotationAngle*Time.deltaTime);
        transform.LookAt(pivotObject);
    }
}
