using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

	public int score = 0; // The player's score.
	private int previousScore = 0; // The score in the previous
	public Text cdsc;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// Set the score text.

		cdsc.text = "Score:" + score.ToString ();
		// Set the previous score to this frame's score.
		previousScore = score;
	
	}
}
