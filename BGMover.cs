using UnityEngine;
using System.Collections;

public class BGMover : MonoBehaviour {

	Rigidbody2D player;
	
	void Start () {
		
		player = GetComponent<Rigidbody2D>();
		GameObject player_go = GameObject.FindGameObjectWithTag("Player");
		
		
		if( player_go == null) {
			Debug.Log("Couldn't find 'Player'! ");
			return;
		}
		
		player = player_go.GetComponent<Rigidbody2D>();
	}
	
	
	
	void FixedUpdate () {
		
		
		
		float vel = player.velocity.x * -0.2f;
		
		transform.position = transform.position + Vector3.right * vel * Time.deltaTime;


	}
}

