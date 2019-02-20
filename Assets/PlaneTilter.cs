﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneTilter : MonoBehaviour
{

    //currently not working on the pinball machine

    private float maxTilt = 10;
    private float minTilt = -10;
    private float rotateSpeed = 1f;

    private float xAxisValue;
    private float zAxisValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Input
        if (Input.GetButton("aKey")) 
        {
            if(zAxisValue <= maxTilt)
                zAxisValue += rotateSpeed;
        }

        if (Input.GetButton("wKey"))
        {
            if (xAxisValue <= maxTilt)
                xAxisValue += rotateSpeed;
        }

        if (Input.GetButton("sKey"))
        {
            if (xAxisValue >= minTilt)
                xAxisValue -= rotateSpeed;
        }

        if (Input.GetButton("dKey"))
        {
            if (zAxisValue >= minTilt)
                zAxisValue -= rotateSpeed;
        }

        //titlting the TitlePlane 
        transform.localRotation = Quaternion.Euler(xAxisValue, 0, zAxisValue);


    }
}
