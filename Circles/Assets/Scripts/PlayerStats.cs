using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour {

	public PlayerBounce pb;

	[SerializeField]
	private Text _scoreText;
	private int _playerScore;
	[SerializeField]
	private AudioSource _popSound;

	// Use this for initialization
	void Start () {
		
		_playerScore = 0;

	}
	
	// Update is called once per frame
	void Update () {

		_scoreText.text = "" + _playerScore;

	}

	void OnTriggerEnter2D (Collider2D col) {

		if (col.tag == "Point") {
			_popSound.Play ();
			Destroy (col.gameObject);
			_playerScore++;
		}
	}
}
