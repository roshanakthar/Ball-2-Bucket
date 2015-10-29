using UnityEngine;
using System.Collections;

public class BonusBallGenarator : MonoBehaviour {

	
	public Transform point;
	public Vector3 positionBall;

	public GameObject ball;

	GameObject bounsBall;

	// Use this for initialization
	void Start () {

		InvokeRepeating ("genarateBonusBall", 10f, 3f);
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	void genarateBonusBall(){
		
		positionBall = new Vector3 (Random.Range (-4.35f, 4.35f ), Random.Range (-3.8f, 3.8f), 0);
		
		point.position = positionBall;
		
		Instantiate (ball, point.position, point.rotation);
		
		//Invoke ("destryBonusBall", 5);
	}
	
	void destryBonusBall(){
			bounsBall = GameObject.FindWithTag ("bounsball");
		    Destroy (bounsBall);
	}
}

