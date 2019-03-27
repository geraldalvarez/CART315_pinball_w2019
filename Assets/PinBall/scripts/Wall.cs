using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public Score score;
    public string wallPosition;
    public GameObject flipper;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(score.getScore() >= 0 && score.getScore() < 100)
        {
            if(wallPosition == "horizontal")
            {
                this.transform.localScale = new Vector3(10f, .5f, .5f);
                GetComponent<BoxCollider>().enabled = true;
                GetComponent<MeshRenderer>().enabled = true;
                flipper.GetComponent<BoxCollider>().enabled = false;
                flipper.GetComponent<MeshRenderer>().enabled = false;
            }

            if(wallPosition == "vertical")
            {
                this.transform.localScale = new Vector3(.5f, .5f, 10f);
                GetComponent<BoxCollider>().enabled = true;
                GetComponent<MeshRenderer>().enabled = true;
                flipper.GetComponent<BoxCollider>().enabled = false;
                flipper.GetComponent<MeshRenderer>().enabled = false;
            }
        }

        if (score.getScore() >= 100 && score.getScore() < 250)
        {
            if (wallPosition == "horizontal")
            {
                this.transform.localScale = new Vector3(7.5f, .5f, .5f);
                GetComponent<BoxCollider>().enabled = true;
                GetComponent<MeshRenderer>().enabled = true;
                flipper.GetComponent<BoxCollider>().enabled = false;
                flipper.GetComponent<MeshRenderer>().enabled = false;
            }

            if (wallPosition == "vertical")
            {
                this.transform.localScale = new Vector3(.5f, .5f, 7.5f);
                GetComponent<BoxCollider>().enabled = true;
                GetComponent<MeshRenderer>().enabled = true;
                flipper.GetComponent<BoxCollider>().enabled = false;
                flipper.GetComponent<MeshRenderer>().enabled = false;
            }
        }

        if (score.getScore() >= 250 && score.getScore() < 600)
        {
            if (wallPosition == "horizontal")
            {
                this.transform.localScale = new Vector3(5f, .5f, .5f);
                GetComponent<BoxCollider>().enabled = true;
                GetComponent<MeshRenderer>().enabled = true;
                flipper.GetComponent<BoxCollider>().enabled = false;
                flipper.GetComponent<MeshRenderer>().enabled = false;
            }

            if (wallPosition == "vertical")
            {
                this.transform.localScale = new Vector3(.5f, .5f, 5f);
                GetComponent<BoxCollider>().enabled = true;
                GetComponent<MeshRenderer>().enabled = true;
                flipper.GetComponent<BoxCollider>().enabled = false;
                flipper.GetComponent<MeshRenderer>().enabled = false;
            }
        }

        if (score.getScore() >= 600 && score.getScore() < 1000)
        {
            if (wallPosition == "horizontal")
            {
                this.transform.localScale = new Vector3(3f, .5f, .5f);
                GetComponent<BoxCollider>().enabled = true;
                GetComponent<MeshRenderer>().enabled = true;
                flipper.GetComponent<BoxCollider>().enabled = false;
                flipper.GetComponent<MeshRenderer>().enabled = false;
            }

            if (wallPosition == "vertical")
            {
                this.transform.localScale = new Vector3(.5f, .5f, 3f);
                GetComponent<BoxCollider>().enabled = true;
                GetComponent<MeshRenderer>().enabled = true;
                flipper.GetComponent<BoxCollider>().enabled = false;
                flipper.GetComponent<MeshRenderer>().enabled = false;
            }
        }

        if (score.getScore() >= 1000)
        {
            if (wallPosition == "horizontal")
            {
                this.transform.localScale = new Vector3(1.5f, .5f, .5f);
                GetComponent<BoxCollider>().enabled = false;
                GetComponent<MeshRenderer>().enabled = false;
                flipper.GetComponent<BoxCollider>().enabled = true;
                flipper.GetComponent<MeshRenderer>().enabled = true;
            }

            if (wallPosition == "vertical")
            {
                this.transform.localScale = new Vector3(.5f, .5f, 1.5f);
                GetComponent<BoxCollider>().enabled = false;
                GetComponent<MeshRenderer>().enabled = false;
                flipper.GetComponent<BoxCollider>().enabled = true;
                flipper.GetComponent<MeshRenderer>().enabled = true;
            }
        }
    }
}
