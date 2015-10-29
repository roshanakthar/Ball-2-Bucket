using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

	public Vector2 velocity = new Vector2(-4, 0);
	public Rigidbody2D rigidbody2D;
	public float range = 4;

	// Use this for initialization
	void Start () {

		rigidbody2D = GetComponent<Rigidbody2D> ();
		rigidbody2D.velocity = new Vector2 (-4, 0); 

		transform.position = new Vector3(transform.position.x, transform.position.y - range * Random.value, transform.position.z);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
