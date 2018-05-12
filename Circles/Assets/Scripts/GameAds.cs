using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class GameAds : MonoBehaviour {

	private PlayerBounce playerBounce;

	void Start() {
		playerBounce = GameObject.FindObjectOfType<PlayerBounce> ();
	}

	public void RunAdvertisement () {

		if (Advertisement.IsReady("rewardedVideo")) {
			Advertisement.Show ("rewardedVideo");
		}
	}

	private void HandleShowResult(ShowResult result) {

		switch (result) {
		case ShowResult.Finished:
			PlayerBounce._playerhealth = PlayerBounce._playerhealth + 1;
			//Add special heart visible in corner
			Debug.Log ("Health added");
			break;

		case ShowResult.Failed:

			break;
		}

	}
}
