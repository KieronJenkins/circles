using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounce : MonoBehaviour {

	[HideInInspector]
	private float _playerBounce = 750f; // Sets the amount the player bounces upwards
	[SerializeField]
	private Rigidbody2D _rb; // The rigidbody connected to the player
	[HideInInspector]
	private string _mainColour; // The colour of the player
	[SerializeField]
	private SpriteRenderer _sr;
	[SerializeField]
	private Color _blue;
	[SerializeField]
	private Color _red;
	[SerializeField]
	private Color _purple;
	[SerializeField]
	private Color _yellow;


	// Use this for initialization
	void Start () {

		MainPlayerColour ();

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump") || Input.GetMouseButtonDown (0)) { // When the player presses space or left mouse click

			_rb.velocity = Vector2.up * _playerBounce; // The player bounces upwards

		}
			
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag != _mainColour) {
			
			Debug.Log ("GAME OVER");
		}

		if (col.tag == "Point") {
			MainPlayerColour ();
		}
	}

	void MainPlayerColour () {

		int colourSwitch = Random.Range (0, 4); // Select a random number between 0 and 3
		switch (colourSwitch) {
		case 0: 
			_mainColour = "Red"; // If the random number chosen is 0, set the mainColour tag to red
			_sr.color = _red; // Sets the players colour to red
			break; // exits the current loop
		case 1: 
			_mainColour = "Yellow";
			_sr.color = _yellow;
			break;
		case 2: 
			_mainColour = "Blue";
			_sr.color = _blue;
			break;
		case 3: 
			_mainColour = "Purple";
			_sr.color = _purple;
			break;

		}
	}
}