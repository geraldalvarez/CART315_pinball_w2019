using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour {

    public Score theScore;
	public string button = "LeftFlipper";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (Input.GetButton (button)) {
			this.GetComponent<HingeJoint> ().useMotor = true;
            theScore.ResetMultiplier();
		} else {
			this.GetComponent<HingeJoint> ().useMotor = false;
		}
	}
}
