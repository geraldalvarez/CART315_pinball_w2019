using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private Vector3 initialPosition;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = ball.transform.position;
        Debug.Log(initialPosition);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == ball)
        {
            Debug.Log("Collision detected");
            ball.transform.position = initialPosition;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == ball)
        {
            Debug.Log("Collision detected");
            ball.transform.position = initialPosition;
        }
    }
}
