using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

	//------------------------------------------------------------------------------------------------------

	[SerializeField]
	private GameObject _pauseMenu; // The pause menu game object

	//------------------------------------------------------------------------------------------------------

	// Use this for initialization
	void Start () 
	{

	_pauseMenu.SetActive (false); // On start sets the pause menu to invisible
		
	}

	//------------------------------------------------------------------------------------------------------

	public void Pause () 
	{
		
		Time.timeScale = 0f; // Pauses the game
		_pauseMenu.SetActive (true); // Makes the pause menu visible

	}

	//------------------------------------------------------------------------------------------------------

	public void Unpause () 
	{
		Time.timeScale = 1f; // Unpauses the game
		_pauseMenu.SetActive (false); // Makes the pause menu invisible
	}
}
