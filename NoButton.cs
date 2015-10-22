using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NoButton : MonoBehaviour {

	// Use this for initialization
	public void onNoPress() {
		PlayerMovement.noPressed = true;
		PlayerMovement.exitPressed = 1;
	}
}
