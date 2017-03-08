using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applyInitialVelocity : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -50000));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
