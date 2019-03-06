﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{

    public Score theScore;
    private int timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (timer == 0)
        {
            this.GetComponent<ConstantForce>().enabled = false;
        }
        else
        {
            timer--;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(timer == 0)
        {
            theScore.AddScore(5);
            theScore.AddMultiplier(1);
        }

        this.GetComponent<AudioSource>().Play();
        this.GetComponent<ConstantForce>().enabled = true;

        timer = 3;
    }
}
