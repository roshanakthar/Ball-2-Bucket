using UnityEngine;
using System.Collections;

public class BonusBall : MonoBehaviour {

//	public Transform point;
//	public GameObject ball;
//
//	public float delay = 7f;
//	public float start  = 3f;
//	public Vector3 positionBall;

	GameObject [] ballOrg;
	GameObject [] ballgreen;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		//Checking the number of the objects in the screen 
		ballOrg = GameObject.FindGameObjectsWithTag ("ballorange");
		ballgreen = GameObject.FindGameObjectsWithTag ("ballgreen");

	}

	void OnTriggerEnter2D(Collider2D other){
	
		if (other.gameObject.tag == "bucketgreen") {

			int score = PlayerPrefs.GetInt("score");
			int count  = ballOrg.Length + ballgreen.Length;
			score += count;
			PlayerPrefs.SetInt("score",score);


			//Destroying objects 
			for (int i = 0; i < ballOrg.Length; i++) {
				Destroy (ballOrg [i]);
			}

			for (int i = 0; i < ballgreen.Length; i++) {
				Destroy (ballgreen [i]);
			}

			GameObject g  = GameObject.FindWithTag("bounsball");
			Destroy(g);
		} else {
		
			//End game 
			//Application.LoadLevel(1);
		}

		//Destroy (gameObject);
	}


}
