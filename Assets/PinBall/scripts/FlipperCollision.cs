using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperCollision : MonoBehaviour
{
    public GameObject ball;
    private bool hit = false;

    private float timer;
    private float resetTime = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
            timer += Time.fixedDeltaTime;

            if (timer > resetTime)
            {

            if (hit)
            {
                this.GetComponent<HingeJoint>().useMotor = false;
                hit = false;
            }

            
            timer -= resetTime;
            }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == ball)
        {
            hit = true;
            this.GetComponent<HingeJoint>().useMotor = true;
        }
        else
        {
   
        }
    }
}
