using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	static int score = 0;
	public static int highScore = 0;
	public static Text text;
	public static bool rateUs = false;
	//int[] medals = {10,20,30,40,50,60,70,80,90,100);



	static public void AddPoint() {
		score++;



		if(score > highScore){
		highScore = score;

		}


	}

     //Use this for initialization
	void Start () {



		text = GetComponent<Text>();
		score = 0;
		highScore = 0;
		highScore = PlayerPrefs.GetInt("highScore", 0);

	}

	void OnDestroy(){
	PlayerPrefs.SetInt("highScore", highScore);
	}				

	
	// Update is called once per frame
	void Update () {


		//TODO Add Points to the game which the player collects and can unlock new characters.

		if(score >= 25 && PlayerMovement.isDead){
			if(PlayerMovement.exitPressed ==0){
				Debug.Log("hm");
			rateUs = true;
			}
		}


		if(score == 10){
			//This will be medal for 10 points!
			Debug.Log("works1!");

		}

		if(score == 20){
			//This will be medal for 20 points!
			Debug.Log("works2!");
			
		}

		if(score == 30){
			//This will be medal for 30 points!
			Debug.Log("works3!");
			
		}

		if(score == 40){
			//This will be medal for 40 points!
			Debug.Log("works4!");
			
		}

		if(score == 50){
			//This will be medal for 50 points!
			Debug.Log("works5!");
			
		}


		if(Time.timeScale == 0){
			text.enabled = false;
		}else{
			text.enabled = true;
		}
		text.text = "" + score;




	}
}
