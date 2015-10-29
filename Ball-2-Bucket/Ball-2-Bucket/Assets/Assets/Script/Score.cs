using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public TextMesh currentScore;


	GameObject ball;
	int score = 0;

	void Start(){
		PlayerPrefs.SetInt ("score", score);
	}

	void Update () {

		score = PlayerPrefs.GetInt("score");

		currentScore.text = score.ToString();

	}

	void OnCollisionEnter2D(Collision2D other){

		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
	
	}



}
