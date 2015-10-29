using UnityEngine;
using System.Collections;

public class DeadZoneDetector : MonoBehaviour {

	GameObject ball;

	// Use this for initialization
	void Start () {
	
		ball = GameObject.FindGameObjectWithTag ("Ball");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){

		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();

		//Application.Quit();

		;


//		Debug.Log ("trigger");

		if (other.tag == "ballgreen") {

			Debug.Log ("Yes");

		
		}
	}
}
