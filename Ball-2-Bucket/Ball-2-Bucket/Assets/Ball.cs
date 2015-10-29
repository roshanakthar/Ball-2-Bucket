using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	int score = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D other){
		
		if (other.gameObject.tag == "bucketgreen") {

			//Correct bucket set score
			score = PlayerPrefs.GetInt("score");
			score += 1;
		
			PlayerPrefs.SetInt ("score", score);
			Destroy (gameObject);
				
		}

		if (other.gameObject.tag == "bucketorange") {
			
			//Load application 
			//Application.LoadLevel (1);
			Destroy (gameObject);

		}

	}
}
