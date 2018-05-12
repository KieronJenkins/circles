using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour {

	//------------------------------------------------------------------------------------------------------

	public PlayerBounce pb;
	[SerializeField]
	private Text _scoreText;
	private int _playerScore;
	[SerializeField]
	private AudioSource _popSound;

	//------------------------------------------------------------------------------------------------------

	// Use this for initialization
	void Start () {
		
		_playerScore = 0; // Sets the players score to 0 on start

	}

	//------------------------------------------------------------------------------------------------------

	// Update is called once per frame
	void Update () {

		_scoreText.text = "" + _playerScore; // Checks the players score

	}

	//------------------------------------------------------------------------------------------------------

	void OnTriggerEnter2D (Collider2D col) {

		if (col.tag == "Point") { // If the player collides with object with the tag of Point
			_popSound.Play (); // Play sound
			Destroy (col.gameObject); // Destroy Point object
			_playerScore++; // Add 1 to score
		}
	}
}
