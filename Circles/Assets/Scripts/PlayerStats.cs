using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour {

	//------------------------------------------------------------------------------------------------------

	[SerializeField]
	private Text _scoreText; // The text to display the score
	public int _playerScore; // The players score
	[SerializeField] // Show in inspector even though its private
	private AudioSource _popSound; // The sound played when the user picks up a point

	//------------------------------------------------------------------------------------------------------

	// Use this for initialization
	void Start () 
	{
		
		_playerScore = 0; // Sets the players score to 0 on start

	}

	//------------------------------------------------------------------------------------------------------

	// Update is called once per frame
	void Update () 
	{

		_scoreText.text = "" + _playerScore; // Checks the players score

	}

	//------------------------------------------------------------------------------------------------------

	void OnTriggerEnter2D (Collider2D col) 
	{

		if (col.tag == "Point") { // If the player collides with object with the tag of Point
			_popSound.Play (); // Play sound
			Destroy (col.gameObject); // Destroy Point object
			_playerScore++; // Add 1 to score
		}
	}
}
