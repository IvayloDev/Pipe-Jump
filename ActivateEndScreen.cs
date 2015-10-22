using UnityEngine;
using System.Collections;

public class ActivateEndScreen : MonoBehaviour {

	public GameObject endScreen;
	public static int adCount;

	void Update () {
		endScreen.SetActive(false);
		if(PlayerMovement.isDead){
			endScreen.SetActive(true);
			}
	}

}
