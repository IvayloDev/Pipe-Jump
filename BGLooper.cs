using UnityEngine;
using System.Collections;

public class BGLooper : MonoBehaviour {

	int BG = 6;
	float pipeMinHeight = -8.5f;//-0.8f;
	float pipeMaxHeight = -7f;//-3.5f;

	void Start (){

		GameObject[] pipes = GameObject.FindGameObjectsWithTag("Pipe");

		foreach(GameObject pipe in pipes) {

			Vector3 pos = pipe.transform.position;
			pos.y = Random.Range(pipeMinHeight, pipeMaxHeight);
			pipe.transform.position = pos;

		}

	}

		void OnTriggerEnter2D(Collider2D collider){


		if(collider.CompareTag("BG") || collider.CompareTag("Pipe") || collider.CompareTag("Clouds")){

			float widthOfObject = ((BoxCollider2D)collider).size.x;

		Vector3 pos = collider.transform.position;

			pos.x += widthOfObject * BG * 11.5f;

			if(collider.tag == ("Pipe")){

				pos.y = Random.Range(pipeMinHeight, pipeMaxHeight);
			}

			collider.transform.position = pos;

		}
	}
}
