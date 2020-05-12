using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class ShowAdScript : MonoBehaviour {
	public void PlayAd () {
		if (Advertisement.IsReady ()) {
			Advertisement.Show ("rewardedVideo", new ShowOptions { resultCallback = AdResult });
		}
	}

	void AdResult (ShowResult showResult) {
		switch (showResult) {
		case ShowResult.Failed:
			Debug.Log ("Ad failed");
			break;
		case ShowResult.Skipped:
			Debug.Log ("Ad skipped");
			break;
		case ShowResult.Finished:
			Debug.Log ("Ad successfully finished (Make a reward)");
			break;
		}
	}
}
