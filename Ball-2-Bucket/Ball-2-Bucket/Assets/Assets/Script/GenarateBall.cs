using UnityEngine;
using System.Collections;

public class GenarateBall : MonoBehaviour {


	public Transform point;

	public GameObject ballGreen;
	public GameObject ballOrange;
	public Vector3 positionBall;
	Transform pos ;

	public float delay = 20f;
	public float start  = 10f;

	public float delayOrg = 22f;
	public float startOrg  = 13f;

//	int countGreen = 0;
//	int countOrange = 0;

	GameObject [] ballOrg;
	GameObject [] ballgreen;
	//cddasc

	// Use this for initializationc
	void Start () {
	
		InvokeRepeating ("genarateBallGreen", start, delay); 

		InvokeRepeating ("genarateBallOrange", startOrg, delayOrg); 


	}
	
	// Update is called once per frame
	void Update () {
	
		//Checking the number of the objects in the screen 
		ballOrg = GameObject.FindGameObjectsWithTag ("ballorange");
		ballgreen = GameObject.FindGameObjectsWithTag ("ballgreen");
	   
		if ((ballOrg.Length + ballgreen.Length) > 15) {
			//Application.LoadLevel (1);
		}


	}

	void genarateBallGreen(){

		positionBall = new Vector3 (Random.Range (-4.35f, 4.35f ), Random.Range (-3.8f, 3.8f), 0);

		point.position = positionBall;

		Instantiate (ballGreen, point.position, point.rotation);

	}

	void genarateBallOrange(){
		
		positionBall = new Vector3 (Random.Range (-4.35f, 4.35f ), Random.Range (-3.8f, 3.8f), 0);
		
		point.position = positionBall;
		
		Instantiate (ballOrange, point.position, point.rotation);
		
	}
}
