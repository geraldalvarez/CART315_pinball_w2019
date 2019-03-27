using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTransform : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;

    private bool toogleSwitch = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("fKey"))
        {
            Debug.Log("Changing The Mesh");


            if (toogleSwitch)
            {
                changeMeshToShere();
            }
            else
            {
                changeMeshToCube();
            }

            toogleSwitch = !toogleSwitch;
        }
    }

    void changeMeshToShere()
    {
        Mesh mesh = sphere.GetComponent<MeshFilter>().sharedMesh;
        Mesh mesh2 = Instantiate(mesh);
        GetComponent<MeshFilter>().sharedMesh = mesh2;
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<SphereCollider>().enabled = true;
    }

    void changeMeshToCube()
    {
        Mesh mesh = cube.GetComponent<MeshFilter>().sharedMesh;
        Mesh mesh2 = Instantiate(mesh);
        GetComponent<MeshFilter>().sharedMesh = mesh2;
        GetComponent<BoxCollider>().enabled = true;
        GetComponent<SphereCollider>().enabled = true;
    }
}
