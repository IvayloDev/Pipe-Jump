using UnityEngine;
using System.Collections;

public class menuButton : MonoBehaviour {

	public GameObject menuPanel;
	public GameObject musicOn;
	public GameObject musicOff;
	public static bool dontJump = false;
	public static bool checkForJump = false;
	public static bool turnOffMusic = false;

	void Start() {
		menuPanel.SetActive(false);
	}

	public void onMenuButtonClick(){
		Time.timeScale = 0;
		menuPanel.SetActive(true);
		dontJump = true;
		checkForJump = true;
	}

	public void onResumeButtonClick(){
		menuPanel.SetActive(false);
		Time.timeScale = 1;
		dontJump = false;
		checkForJump = false;
	}

	public void onMusicButtonClick(){
		musicOn.SetActive(false);
		musicOff.SetActive(true);
		turnOffMusic = true;
	}
	public void onMusicOffButtonClick(){
		turnOffMusic = false;
		musicOff.SetActive(false);
		musicOn.SetActive(true);
	}
}


