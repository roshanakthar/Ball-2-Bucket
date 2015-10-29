using UnityEngine;
using System.Collections;

public class ShowScore : MonoBehaviour {

	public TextMesh score;
	public TextMesh bestScore;
	
	void Awake(){

		if (PlayerPrefs.GetInt("score") > PlayerPrefs.GetInt ("bestscore")) {
			int sc = PlayerPrefs.GetInt("score");
			PlayerPrefs.SetInt("bestscore", sc);
		}

		bestScore.text = "" + PlayerPrefs.GetInt("bestscore");
		score.text = "" + PlayerPrefs.GetInt("score");
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
