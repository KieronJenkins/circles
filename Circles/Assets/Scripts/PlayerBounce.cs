using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Allows the use of ui in the main scene

public class PlayerBounce : MonoBehaviour {

	[HideInInspector]
	private float _playerBounce = 700f; // Sets the amount the player bounces upwards
	[SerializeField] // Shows private variables in the inspector
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
	public static int _playerhealth;
	[SerializeField]
	private GameObject _playerHeartOne;
	[SerializeField]
	private GameObject _playerHeartTwo;
	[SerializeField]
	private GameObject _playerHeartThree;

	//-----------------------------------------------------------------------------------------------------

	// Use this for initialization
	void Start () {

		MainPlayerColour (); // Randomises players colour on start
		_playerhealth = 3; // The players health is set to 3 on start
		_playerHeartOne.SetActive (true); // On start the first heart is visible
		_playerHeartTwo.SetActive (true); // On start the second heart is visible
		_playerHeartThree.SetActive (true); // On start the third heart is visible


	}

	//-----------------------------------------------------------------------------------------------------

	// Update is called once per frame
	void Update () {
		
		PlayerMovement (); // Run the PlayerMovement method

	}

	//-----------------------------------------------------------------------------------------------------

	void PlayerMovement () {

		if (Input.GetButtonDown ("Jump") || Input.GetMouseButtonDown (0)) { // When the player presses space or left mouse click

			_rb.velocity = Vector2.up * _playerBounce; // The player bounces upwards

		}

	}

	//-----------------------------------------------------------------------------------------------------

	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag != _mainColour && col.tag != "Point" && col.tag != "Barrier" && col.tag != "BarrierTwo") { // If the player collides with an object and the tag doesnt match the _mainColour text
			
		
			if (_playerhealth > 0) { // If the players health is greater than 0

				_playerhealth = _playerhealth - 1; // Minus 1 from the players health
				_playerHeartOne.SetActive (false); // Make the first heart gameobject invisible / not active

				if (_playerhealth == 1) // If the players health is equal to 1
				{
					_playerHeartTwo.SetActive (false); // Make the second heart gameobject invisible / not active
				}

			} else if (_playerhealth <= 0) { // If the players health is less than or equal to 0
				_playerHeartThree.SetActive (false); // Make the third heart gameobject invisible / not active
				SceneManager.LoadScene ("Circles_MainGame"); // Reset the level
			}
		}

		if (col.tag == "Point") { // If the player collides with an object with the tag of Point
			MainPlayerColour (); // Run MainPlayerColour method
		}
	}

	//-----------------------------------------------------------------------------------------------------

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
			
			if (_mainColour == "Yellow") { // If the players colour is already Yellow
				MainPlayerColour (); // Rerun the method to get new colour
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

	//-----------------------------------------------------------------------------------------------------
}