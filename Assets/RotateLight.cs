using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLight : MonoBehaviour
{
    public Transform pivotObject;
    public float rotationAngle = 15f;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(pivotObject.transform.position, new Vector3(1, 0, 0), rotationAngle*Time.deltaTime);
    }
}
