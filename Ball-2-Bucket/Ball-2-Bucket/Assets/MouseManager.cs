using UnityEngine;
using System.Collections; 

public enum Swipe { None, Up, Down, Left, Right };


public class MouseManager : MonoBehaviour {

	Rigidbody2D grabbedObject = null;
	float dragSpeed = 10f; 



	Vector2 direction;
	float speed;

	public float minSwipeLength = 5f;
	Vector2 firstPressPos;
	Vector2 secondPressPos;
	Vector2 currentSwipe;

	Vector2 firstClickPos;
	Vector2 secondClickPos;
	
	public static Swipe swipeDirection;


//	private float length = 0;
//	private bool SW = false;
//	private Vector3 final;
//	private Vector3 startpos;
//	private Vector3 endpos;

	// Update is called once per frame
	void Update () {
		////////////////////---------- /////////////////////////

//		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) 
//		{
//			Debug.Log("touch");
//			final = Vector3.zero;
//			length = 0;
//			SW = false;
//			Vector2 touchDeltaPosition = Input.GetTouch (0).position;
//			startpos = new Vector3 (touchDeltaPosition.x, 0, touchDeltaPosition.y);
//		}      
//		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved) 
//		{
//			SW = true;
//		}
//		
//		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Canceled) 
//		{
//			SW = false;
//		}
//		
//		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Stationary) 
//		{
//			SW = false;
//		}
//		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Ended) 
//		{
//			if (SW) 
//			{
//				Vector2 touchPosition = Input.GetTouch (0).position;
//				endpos = new Vector3 (touchPosition.x, 0, touchPosition.y);
//				final = endpos - startpos;
//				length = final.magnitude;
//			}
//		} 
//

		////////////////////---------- /////////////////////////




		//DetectSwipe();

		if ( Input.GetMouseButtonDown(0)) {

			Vector3 mouseWorldPos3D = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector2 mousePos2D = new Vector2(mouseWorldPos3D.x,mouseWorldPos3D.y);

			Vector2 dir = Vector2.zero;

			RaycastHit2D hit = Physics2D.Raycast(mousePos2D,dir);
			if(hit != null && hit.collider != null){


				if(hit.collider.GetComponent<Rigidbody2D>() != null){
					grabbedObject = hit.collider.GetComponent<Rigidbody2D>();


				}
			}
		
		}

		if (Input.GetMouseButtonUp(0)) {
		
			grabbedObject = null;
		
		}
//
//		if(Input.touches[0].phase == TouchPhase.Moved)//Check if Touch has moved.
//		{
//			direction = Input.touches[0].deltaPosition.normalized;  //Unit Vector of change in position
//			speed = Input.touches[0].deltaPosition.magnitude / Input.touches[0].deltaTime; //distance traveled divided by time elapsed
//		}

	}


	void FixedUpdate(){

		if (grabbedObject != null) {
//			Vector3 MouseworldPos3D = Camera.main.ScreenToWorldPoint(Input.mousePosition);
//			Vector2 mousePos2D = new Vector2(MouseworldPos3D.x, MouseworldPos3D.y);
//			grabbedObject.position = mousePos2D;

			Vector3 MouseworldPos3D = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector2 mousePos2D = new Vector2(MouseworldPos3D.x, MouseworldPos3D.y);

			Vector2 dir = mousePos2D - grabbedObject.position;
			dir *= dragSpeed;

			grabbedObject.velocity = dir;
		}
	}


//	public void DetectSwipe ()
//	{
//		if (Input.touches.Length > 0) {
//			Touch t = Input.GetTouch(0);
//			
//			if (t.phase == TouchPhase.Began) {
//				firstPressPos = new Vector2(t.position.x, t.position.y);
//			}
//			
//			if (t.phase == TouchPhase.Ended) {
//				secondPressPos = new Vector2(t.position.x, t.position.y);
//				currentSwipe = new Vector3(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);
//				
//				// Make sure it was a legit swipe, not a tap
//				if (currentSwipe.magnitude < minSwipeLength) {
//					swipeDirection = Swipe.None;
//					return;
//				}
//				
//				currentSwipe.Normalize();
//				
//				// Swipe up
//				if (currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f) {
//					swipeDirection = Swipe.Up;
//
//					// Swipe down
//				} else if (currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f) {
//					swipeDirection = Swipe.Down;
//					// Swipe left
//				} else if (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f) {
//					swipeDirection = Swipe.Left;
//					// Swipe right
//				} else if (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f) {
//					swipeDirection = Swipe.Right;
//				}
//			}
//		} else {
//			
//			if (Input.GetMouseButtonDown(0)) {
//				firstClickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
//			} else {
//				swipeDirection = Swipe.None;
//				//Debug.Log ("None");
//			}
//			if (Input.GetMouseButtonUp (0)){
//				secondClickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
//				currentSwipe = new Vector3(secondClickPos.x - firstClickPos.x, secondClickPos.y - firstClickPos.y);
//				
//				// Make sure it was a legit swipe, not a tap
//				if (currentSwipe.magnitude < minSwipeLength) {
//					swipeDirection = Swipe.None;
//					return;
//				}
//				
//				currentSwipe.Normalize();
//				
//				//Swipe directional check
//				// Swipe up
//				if (currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f) {
//					swipeDirection = Swipe.Up;
//					// Swipe down
//					Debug.Log ("up");
//				} else if (currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f) {
//					swipeDirection = Swipe.Down;
//					// Swipe left
//					Debug.Log ("down");
//				} else if (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f) {
//					swipeDirection = Swipe.Left;
//					Debug.Log ("Left");
//					// Swipe right
//				} else if (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f) {
//					swipeDirection = Swipe.Right;
//					Debug.Log ("right");
//				}
//			}
//			
//		}
//	}

}





