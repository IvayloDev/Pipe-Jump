using UnityEngine;
using System.Collections;

public class RestartGameScript : MonoBehaviour {

	public static bool restartClick =false;


	public void RestartGame () {
			Application.LoadLevel(Application.loadedLevel);
	}
}
