using UnityEngine;
using System.Collections;

public class StartScreen : MonoBehaviour {

	public static bool sawOnce = false;
	SpriteRenderer picture1;
	public GameObject menuButt;

	void Start() {
    picture1 = GetComponent<SpriteRenderer>();
		
		if(!sawOnce){
			picture1.enabled = true;
			menuButt.SetActive(false);
			

			Time.timeScale = 0;
		}else{
			Time.timeScale = 1;
		}
		sawOnce = true	;
	}


	void Update () {	
	
		if(Time.timeScale == 1){
		picture1.enabled = false;
			menuButt.SetActive(true);
		}

		if(Time.timeScale == 0 && Input.GetMouseButtonDown(0)){
			if(Time.timeScale ==0 && menuButton.dontJump){
				return;
			}
		Time.timeScale = 1;
			menuButt.SetActive(true);
		}
			
	if(PlayerMovement.isDead){
	menuButt.SetActive(false);
	}
		if(menuButton.dontJump == true){
			menuButt.SetActive(false);
		}
	}
}
