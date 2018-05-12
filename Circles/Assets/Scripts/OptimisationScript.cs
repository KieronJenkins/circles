using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptimisationScript : MonoBehaviour {

	//------------------------------------------------------------------------------------------------------

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	//------------------------------------------------------------------------------------------------------

	void OnTriggerEnter2D (Collider2D colBar) {

		if (colBar.tag == "Barrier") { // If the object has the tag of Barrier
			GetComponent<Collider2D>().isTrigger = false; // When the player collides with barrier turn off the player colliders trigger
		} 

		if (colBar.tag == "BarrierTwo") {
			GetComponent<Collider2D>().isTrigger = true; // When the player collides with barrier turn off the player colliders trigger
		} 

	}
}
