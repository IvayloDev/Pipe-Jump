using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	Rigidbody2D rb;
	float RightSpeed = 5f;
	float UpSpeed = 480f;
	Vector2 velocity;
	bool jump = false;
   	bool death = false;
	float cooldown = 0.4f;
	public static bool isDead = false;
	public static bool noPressed = false;
	public static int exitPressed = 0;
	public AudioSource jumpSound;
	public static bool menuJump = false;
	
 	//reference to the "Player" Object
	public GameObject player;
	public GameObject rateScreen;







	//If Player Collides with "Enemy"(Pipe) he dies
	void OnCollisionEnter2D(Collision2D collision){

		if(collision.collider.CompareTag("Enemy")){
			death = true;
			ActivateEndScreen.adCount += 1;
		}
 	}



	// Use this for initialization
	void Start () {
		
		isDead = false;
		//reference to the rigidbody of the player
		rb = GetComponent<Rigidbody2D>();
		jumpSound = GetComponent<AudioSource>();
		exitPressed = PlayerPrefs.GetInt("exitPressed",0);

	}


	void Update () {



		if(noPressed){
			ScoreManager.rateUs = false;
			exitPressed = 1;
		}

		if(exitPressed == 1){
			rateScreen.SetActive(false);
		}

			rateScreen.SetActive(false);


			if(death){
			isDead = true;
			
			ScoreManager.text.text = "Best Score: " + ScoreManager.highScore;

		}

		
		if(menuButton.turnOffMusic){
				jumpSound.Stop();
		}
		

		if(death && ScoreManager.rateUs == true){
			rateScreen.SetActive(true);
		}

		//reduce cooldown. When = 0 and user clicks => Jump
		cooldown -= Time.deltaTime;
		if(Input.GetMouseButtonDown(0) && cooldown <=0){
			if(menuButton.dontJump){
			return;
			}


			if(menuJump){
			jump=false;
			}else{
				jump = true;
			}
			if(!isDead){
			jumpSound.Play();
		}
	}

}

	void OnDestroy(){

		PlayerPrefs.SetInt("exitPressed", exitPressed);

	}

	// Update is called once per frame
	void FixedUpdate () {

		//When Player dies
		if(death){
			return;
		}


		// Constant Movement to right
		rb.AddForce(Vector2.right * RightSpeed);

		// Rotate player 
		rb.transform.Rotate(0,0,1);



		//Makes Player Jump
		if(jump){
			jump = false;
			//TODO --jumpSound.Play();
			rb.AddForce(Vector2.up * UpSpeed);
			cooldown = 0.9f;

		}

	}

}
