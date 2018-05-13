using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class GameAds : MonoBehaviour {

	public void QuitGameAd () 
	{

		ShowOptions options = new ShowOptions ();
		options.resultCallback = AdStatus;

		if (Advertisement.IsReady("video")) {
			Advertisement.Show ("video", options);
		} 

	}

	void AdStatus (ShowResult result) {

		switch (result) {
		case ShowResult.Finished:
			Time.timeScale = 1f;
			SceneManager.LoadScene ("Circles_MainMenu"); 
			break;

		case ShowResult.Skipped:
			Time.timeScale = 1f;
			SceneManager.LoadScene ("Circles_MainMenu"); 
			break;

		case ShowResult.Failed:
			Time.timeScale = 1f;
			SceneManager.LoadScene ("Circles_MainMenu"); 
			break;
		}
	}
}
