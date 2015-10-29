using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Vector2 jumpForce = new Vector2(0, 300);
	public Rigidbody2D rigidbody2D; 


	// Use this for initialization
	void Start () {
	
		rigidbody2D = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		// Jump
		if (Input.GetKeyUp("space"))
		{
			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.AddForce(jumpForce);
		}

		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0)
		{
			Die();
		}

	}


	void OnCollisionEnter2D(Collision2D other)
	{
		Die();
	}

	void Die()
	{

		Application.LoadLevel(0);
	}
}
