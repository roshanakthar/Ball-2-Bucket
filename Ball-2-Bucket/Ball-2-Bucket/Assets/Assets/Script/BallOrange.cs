using UnityEngine;
using System.Collections;

public class BallOrange : MonoBehaviour {

	int score = 0;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D other){
		
		if (other.gameObject.tag == "bucketgreen") {
			
			//Load application 
			//Application.LoadLevel (1);
			Destroy (gameObject);

		}
		
		if (other.gameObject.tag == "bucketorange") {

			
			score = PlayerPrefs.GetInt("score");
			score += 1;


			Debug.Log (score);
			PlayerPrefs.SetInt ("score", score);
			
			Destroy (gameObject);


		}
		
	}
}
