using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Allows for scene changing

public class TutorialScript : MonoBehaviour {

	//------------------------------------------------------------------------------------------------------

	RaycastHit raycastTap; // To detect player touching objects with a tag
	[SerializeField]
	private AudioSource _tutorialMusic; // Tutorial backgroud music
	[SerializeField]
	private AudioSource _clickSound; // Click sound audio

	//------------------------------------------------------------------------------------------------------

	// Update is called once per frame
	void Update () {

		NextLevelClick (); // Runs the NextLevelClick method
		TutorialBackClick (); // Runs the TutorialBackClick method
	}

	//------------------------------------------------------------------------------------------------------

	void NextLevelClick () {

		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) // If the user is touching / tapping the target and has took their finger off the screen and theres atleast 1 bullet
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position); // Ray is wherever the player touches on the screen
			if (Physics.Raycast(ray, out raycastTap)) // When the player touches the screen
			{
				if (raycastTap.collider.tag == "TutGo") // And if the object has the tag "TutGo"
				{
					_clickSound.Play(); // Plays _clickSound sound
					SceneManager.LoadScene("Circles_MainGame"); // Load the main game
				}
			}
		}
	}

	//------------------------------------------------------------------------------------------------------

	void TutorialBackClick () {

		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) // If the user is touching / tapping the target and has took their finger off the screen and theres atleast 1 bullet
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position); // Ray is wherever the player touches on the screen
			if (Physics.Raycast(ray, out raycastTap)) // When the player touches the screen
			{
				if (raycastTap.collider.tag == "TutBack") // And if the object has the tag "TutGo"
				{
					_clickSound.Play(); // Plays _clickSound sound
					SceneManager.LoadScene("Circles_MainMenu"); // Load the main game
				}
			}
		}
	}
}
