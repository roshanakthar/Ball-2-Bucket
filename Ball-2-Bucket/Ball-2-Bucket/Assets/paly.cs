using UnityEngine;
using System.Collections;

public class paly : MonoBehaviour {

	public TextMesh bestScore;


	void OnMouseDown() {
	
		Application.LoadLevel (0);
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	 PlayerPrefs.SetInt ("bestscore",2);
		if (PlayerPrefs.GetInt ("bestscore") < 10) {
			bestScore.text = "0" + PlayerPrefs.GetInt ("bestscore").ToString ();
		}
		else {
			bestScore.text = PlayerPrefs.GetInt ("bestscore").ToString ();
		}
	}
}
