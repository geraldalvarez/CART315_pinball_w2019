using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAngle : MonoBehaviour
{
    public Transform ground;
    public Text angleText;
    public string side;

    // Update is called once per frame
    void Update()
    {
        if(side == "top")
        {
            float val = -1 * ground.rotation.x;
            angleText.text = val.ToString();
        }

        if(side == "right")
        {
            float val = -1 * ground.rotation.z;
            angleText.text = val.ToString();
        }

        if(side == "bottom")
        {
            angleText.text = ground.rotation.x.ToString();
        }

        if(side == "left")
        {
            angleText.text = ground.rotation.z.ToString();
        }

        
    }

   
}
