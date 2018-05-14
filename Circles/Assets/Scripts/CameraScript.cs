using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

	[SerializeField]
	private Transform _playerPos; // Players position
	
	void Update () {

		if (_playerPos.position.y > transform.position.y ) { // If the players position is greater than the cameras y position
			transform.position = new Vector3 (_playerPos.position.x, _playerPos.position.y, -1000f); // Move the camera with the player
		}

	}
}
