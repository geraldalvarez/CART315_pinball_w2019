using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShifter : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;
    private GameObject current;
    private Transform objTransform;
    private bool ballCube;
    private bool instantiated = false;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        //sphere instantiate first 
        ballCube = false;

        //create sphere
        current = Instantiate(sphere, transform.position, transform.rotation);
        current.transform.parent = gameObject.transform;

        //transfer current transform data
        objTransform = current.GetComponent<Transform>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //toogle button for switching the ball
        if (Input.GetKeyDown(KeyCode.F))
        {

            if (!instantiated)
            {
                instantiated = true;

                //flip the bool value
                ballCube = !ballCube;

                //transfer the transform data to the new ball
                objTransform = current.GetComponent<Transform>();

                //destroy the current object
                destroBall(current);

                //create the ball
                if (ballCube)
                {
                    //cube
                    createBall(cube);

                }
                else
                {
                    //sphere
                    createBall(sphere);
 
                }
            }

        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            instantiated = false;
            Debug.Log(instantiated);
        }
    }

    void createBall(GameObject obj)
    {
        current = Instantiate(obj, objTransform.position + new Vector3(0, 1f, 0), objTransform.rotation);
        current.transform.parent = gameObject.transform;

        objTransform = current.GetComponent<Transform>();

        count++;
    }

    void destroBall(GameObject obj)
    {
        Destroy(obj);
    }
}
