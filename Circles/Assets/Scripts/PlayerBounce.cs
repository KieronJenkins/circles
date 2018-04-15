using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounce : MonoBehaviour {

	[SerializeField]
	private float _playerBounce = 475f; 
	[SerializeField]
	private Rigidbody2D _rb;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump") || Input.GetMouseButtonDown (0)) 
		{
			_rb.velocity = Vector2.up * _playerBounce;
		}
	}
}