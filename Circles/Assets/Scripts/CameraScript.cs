using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

	[SerializeField]
	private Transform _playerPos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (_playerPos.position.y > transform.position.y ) {
			transform.position = new Vector3 (_playerPos.position.x, _playerPos.position.y, -1000f);
		}

	}
}
