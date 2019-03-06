using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Rigidbody prefab;
    public Transform prefabTransform;
    public string button = "LeftFlipper";

    public int objectCount = 0;
    public bool randomSpawn = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Spawn();
        //when the button is pressed; instantiate an object
        if (Input.GetButton(button))
        {
            Rigidbody prefabInstance;
            prefabInstance = Instantiate(prefab, prefabTransform.position, prefabTransform.rotation) as Rigidbody;
            prefabInstance.AddForce(prefabTransform.forward * 100);
        }

    }

    void Spawn()
    {
        if (randomSpawn)
        {

        }
        else
        {
            //when the button is pressed; instantiate an object
            if (Input.GetButton(button))
            {
                Rigidbody prefabInstance;
                prefabInstance = Instantiate(prefab, prefabTransform.position, prefabTransform.rotation) as Rigidbody;
                prefabInstance.AddForce(prefabTransform.forward * 100);
            }
        }
    }

}

