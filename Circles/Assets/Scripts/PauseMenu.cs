using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

	[SerializeField]
	private GameObject _pauseMenu;

	// Use this for initialization
	void Start () {

	_pauseMenu.SetActive (false);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Pause () {
		Time.timeScale = 0f;
		_pauseMenu.SetActive (true);
	}
}
