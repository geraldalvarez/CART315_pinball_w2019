using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {

	public float rotateSpeed = 1.2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void fixedUpdate () {
		this.transform.Rotate (0,rotateSpeed,0);
	}
}
