using UnityEngine;
using System.Collections;
using GoogleMobileAds;

public class AdController : MonoBehaviour {

	private AdMobPlugin admob;
	private const string Ad_UNIT_ID = "Banner_ID";
	private const string Interstitial_ID = "Interstitial_ID";
	bool seenAd = false;

	void Awake() {
		seenAd = true;
		admob = GetComponent<AdMobPlugin>();
		admob.CreateBanner(Ad_UNIT_ID, AdMobPlugin.AdSize.SMART_BANNER, true, Interstitial_ID);
		admob.RequestAd();
		admob.RequestInterstitial();
		admob.ShowBanner();
	}


	void Update() {
			HandleInterstitialLoaded();
	}
	void OnEnable() {
		AdMobPlugin.InterstitialLoaded += HandleInterstitialLoaded;
	}

	void OnDisable() {
		AdMobPlugin.InterstitialLoaded -= HandleInterstitialLoaded;
	}

	public void HandleInterstitialLoaded() {
		if(PlayerMovement.isDead && seenAd && ActivateEndScreen.adCount == 3){
		admob.ShowInterstitial();
			ActivateEndScreen.adCount = 0;
			seenAd = false; 
		
		}
 	}
}
