using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleScript : MonoBehaviour {

	//------------------------------------------------------------------------------------------------------

	[SerializeField]
	private float _rotateSpeed = 75f; // Sets the circles rotation speed

	//------------------------------------------------------------------------------------------------------

	// Use this for initialization
	void Start () {
		
	}

	//------------------------------------------------------------------------------------------------------
	
	// Update is called once per frame
	void Update () {
		
		CircleRotation (); // Runs the circlerotation method

	}

	//------------------------------------------------------------------------------------------------------

	void CircleRotation ()
	{
		transform.Rotate (0f, 0f, _rotateSpeed * Time.deltaTime); // Rotates the square on its Z axis every second based on the _rotatespeed amount
	}
		
}
