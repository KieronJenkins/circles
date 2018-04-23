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
	[SerializeField]
	private GameObject _player;


	// Use this for initialization
	void Start () {

		MainPlayerColour (); // Randomises players colour on start

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump") || Input.GetMouseButtonDown (0)) { // When the player presses space or left mouse click

			_rb.velocity = Vector2.up * _playerBounce; // The player bounces upwards

		}
			
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag != _mainColour) { // If the player collides with an object and the tag doesnt match the _mainColour text
			
			Debug.Log ("GAME OVER");
		}

		if (col.tag == "Point") { // If the player collides with an object with the tag of Point
			MainPlayerColour (); // Run MainPlayerColour method
		}
	}

	void MainPlayerColour () {

		int colourSwitch = Random.Range (0, 4); // Select a random number between 0 and 3
		switch (colourSwitch) {
		case 0: 
			
			if (_mainColour == "Red") { // If the main colour is already red
				MainPlayerColour (); // Recheck for another colour
				break;
			} else
			_mainColour = "Red"; // If the random number chosen is 0, set the mainColour text to red
			_sr.color = _red; // Sets the players colour to red
			break; // exits the current loop

		case 1: 
			
			if (_mainColour == "Yellow") {
				MainPlayerColour ();
				break;
			} else
			_mainColour = "Yellow";
			_sr.color = _yellow;
			break;

		case 2: 
			
			if (_mainColour == "Blue") {
				MainPlayerColour ();
				break;
			} else
			_mainColour = "Blue";
			_sr.color = _blue;
			break;
		case 3: 
			
			if (_mainColour == "Purple") {
				MainPlayerColour ();
				break;
			} else
			_mainColour = "Purple";
			_sr.color = _purple;
			break;

		}
	}
}