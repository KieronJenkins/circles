using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D (Collider2D colSquare) {

		if (colSquare.gameObject.tag == "SquareDelete") // If the player collides with an object with the tag of Point
		{ 
			Destroy (colSquare.gameObject);
		}

	}
}
