using UnityEngine;
using System.Collections;

public class MoveBucket1 : MonoBehaviour {



	private Vector3 movement = Vector3.left * 0.20f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (transform.position.x > 4)
			movement = Vector3.left * 0.20f;
		else if (transform.position.x < -4)
			movement = Vector3.right * 0.20f;
		
		transform.Translate(movement); 

	}

}
