using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleScript : MonoBehaviour {

	//------------------------------------------------------------------------------------------------------
	[SerializeField]
	private float _rotateSpeed; // Sets the circles rotation speed



	//------------------------------------------------------------------------------------------------------

	// Use this for initialization
	void Start () 
	{
		RandomRotation(); // On start run the RandomRotation method
	}

	//------------------------------------------------------------------------------------------------------
	
	// Update is called once per frame
	void Update () 
	{
		CircleRotation (); // Runs the circle rotation method
	}

	//------------------------------------------------------------------------------------------------------

	void CircleRotation ()
	{
		transform.Rotate (0f, 0f, _rotateSpeed * Time.deltaTime); // Rotates the square on its Z axis every second based on the _rotatespeed amount
	}

	//------------------------------------------------------------------------------------------------------

	void RandomRotation() 
	{
		_rotateSpeed = Random.Range (50f, 250f); // Sets the speed to a random amount between 50 and 200
	}

	//------------------------------------------------------------------------------------------------------
		
}
