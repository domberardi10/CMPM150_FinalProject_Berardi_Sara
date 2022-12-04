
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Manasrotate2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        // object location
        Vector3 pivotPoint = transform.position;
        // origin
        // Vector3 pivotPoint = new Vector3(0f,0f,0f);
        transform.RotateAround(pivotPoint, Vector3.up, 45*Time.deltaTime);
    }
}