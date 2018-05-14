using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareSpawn : MonoBehaviour {

//------------------------------------------------------------------------------------------------------

	public Transform _theSquare; // The object being spawned

//------------------------------------------------------------------------------------------------------

	// Use this for initialization
	void Start () {
		
		for (int i = 1; i < 15; i++) // If there are less than 15 Main squares on the screen, add 1 until it reaches 15 then stop
		{ 
			Instantiate(_theSquare, new Vector3(0, i * 950f, 0), Quaternion.identity); // Spawn the main squares 1050f apart from each other on the y
		}

	}

	//------------------------------------------------------------------------------------------------------

}
