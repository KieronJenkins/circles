using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	private float _playerBounce = 425f;
	[SerializeField]
	private Rigidbody2D _rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		playerJump ();

	}

	void playerJump () {
		
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) {

			_rb.velocity = Vector2.up * _playerBounce;

		}
	}
}
