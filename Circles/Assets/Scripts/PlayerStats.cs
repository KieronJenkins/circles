using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {

	[SerializeField]
	private Text _scoreText;
	private int _playerScore;

	// Use this for initialization
	void Start () {
		
		_playerScore = 0;

	}
	
	// Update is called once per frame
	void Update () {

		_scoreText.text = "Score: " + _playerScore;

	}

	void OnTriggerEnter2D (Collider2D col) {

		if (col.tag == "Point") {
			Destroy (col.gameObject);
			_playerScore++;
		}
	}
}
