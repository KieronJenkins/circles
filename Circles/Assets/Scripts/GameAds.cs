using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements; // Allows for ads
using UnityEngine.SceneManagement; // Allows for scene changing

public class GameAds : MonoBehaviour {

	public void QuitGameAd () 
	{

		ShowOptions options = new ShowOptions ();
		options.resultCallback = AdStatus; // Check the status of the ad

		if (Advertisement.IsReady("video")) { // If the advertisement is ready
			Advertisement.Show ("video", options); // Show the advertisement
		} 

	}

	void AdStatus (ShowResult result) {

		switch (result) {
		case ShowResult.Finished: // If the ad has finished playing
			Time.timeScale = 1f; // Set the timescale to 1 / unpause game
			SceneManager.LoadScene ("Circles_MainMenu"); // Change scene to the main menu
			break;

		case ShowResult.Skipped: // If the ad has been skipped
			Time.timeScale = 1f; // Set the timescale to 1 / unpause game
			SceneManager.LoadScene ("Circles_MainMenu"); // Change scene to the main menu
			break;

		case ShowResult.Failed: // If the ad has failed to play
			Time.timeScale = 1f; // Set the timescale to 1 / unpause game
			Debug.Log("Ad Failed");
			SceneManager.LoadScene ("Circles_MainMenu"); // Change scene to the main menu
			break;
		}
	}
}
