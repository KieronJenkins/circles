using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Allows use of scene manager to change scenes

public class MainMenu : MonoBehaviour
{

	//------------------------------------------------------------------------------------------------------

    RaycastHit raycastTap; // To detect player touching objects with a tag
	[SerializeField] // Display in inspector even though private
    private AudioSource _mainMenuMusic; // Main menu backround music
	[SerializeField]
	private GameObject _soundON; // Sound on image
	[SerializeField]
	private GameObject _soundOFF; // Sound off image
	[SerializeField]
	private AudioSource _clickSoundMM; // When the player clicks something, the sound that will be played

	//------------------------------------------------------------------------------------------------------

	void Start ()
	{
		
		_soundON.SetActive(true); // When the scene loads, set the soundON game object to be visible
		_soundOFF.SetActive(false); // When the scene loads, set the soundON game object to be invisible

	}

	//------------------------------------------------------------------------------------------------------

	void Update () {
		
		TapToStart (); //Run the TapToStart method
		HelpBtn (); //Run the HelpBtn method
		MuteBtn (); //Run the MuteBtn method

	}

	//------------------------------------------------------------------------------------------------------

	void TapToStart()
	{
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) // If the user is touching / tapping the target and has took their finger off the screen and theres atleast 1 bullet
		{
			
			Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position); // Ray is wherever the player touches on the screen
			if (Physics.Raycast(ray, out raycastTap)) // When the player touches the screen
			{
				
				if (raycastTap.collider.tag == "NextLevel") // And if the object has the tag "NextLevel"
				{
					SceneManager.LoadScene("Circles_MainGame"); // Load the main game scene
				}

			}

		}
	}

	//------------------------------------------------------------------------------------------------------

    void HelpBtn()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) // If the user is touching / tapping the target and has took their finger off the screen and theres atleast 1 bullet
        {
			
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position); // Ray is wherever the player touches on the screen
            if (Physics.Raycast(ray, out raycastTap)) // When the player touches the screen
            {
				
                if (raycastTap.collider.tag == "Help") // And if the object has the tag "Help"
                {
					
					_clickSoundMM.Play(); // Plays the click sound
                    SceneManager.LoadScene("Circles_Tutorial"); // Load the tutorial scene

                }

            }

        }
    }

	//------------------------------------------------------------------------------------------------------

   public void MuteBtn()
    {
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) // If the user is touching / tapping the target and has took their finger off the screen and theres atleast 1 bullet
        {
			
			Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position); // Ray is wherever the player touches on the screen
            if (Physics.Raycast(ray, out raycastTap)) // When the player touches the screen
            {
				
                if (raycastTap.collider.tag == "SoundOff") // And if the object has the tag "Help"
                {
					
					_mainMenuMusic.volume = 0.3f; // Sets the backgroud music volume to 0.3
					_soundON.SetActive(true); // Sound on image is visible
					_soundOFF.SetActive(false); // Sound off image is invisible

                }

				else if (raycastTap.collider.tag == "SoundOn") // And if the object has the tag "Help"
				{
					
					_clickSoundMM.Play(); // Plays the clicked sound
					_mainMenuMusic.volume = 0f; // Sets the main menu background music to 0
					_soundON.SetActive(false); // Sound on image is invisible
					_soundOFF.SetActive(true); // Sound off image is visible


				}

            }

        }
    }







}
