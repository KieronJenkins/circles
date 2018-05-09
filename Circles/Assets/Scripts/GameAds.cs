using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class GameAds : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void RunAdvertisement () {

		if (Advertisement.IsReady("rewardedVideo")) {
			Advertisement.Show ("rewardedVideo");
		}

	}
}
