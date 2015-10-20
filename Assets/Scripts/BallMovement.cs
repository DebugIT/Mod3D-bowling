using UnityEngine;
using System.Collections;

/**
 * @Author Piotr Mścichowski
 * 
 * 
 */
public class BallMovement : Ball {

	private Vector3 mouseStartpoint;
	private Vector3 mouseEndPoint;
	private float distance;


	// Use this for initialization
	public override void Start () {
		base.Start ();
	}

	// Update is called once per frame
	public override void Update () {

		//set direction for mouse
		if (Input.GetMouseButton (0)) {
			transform.Rotate (0f, Input.GetAxis ("Mouse X") * turnSpeed * Time.deltaTime, 0f);
		}

		/*Setting direction on Z axis based on mouse */
		if (Input.GetMouseButton (1)) {
		
			Vector3 ballMoveVector = new Vector3(0F, 0f,Mathf.Abs(-Input.GetAxis("Mouse X")) * Mathf.Abs(-Input.GetAxis("Mouse X")) * Time.deltaTime);
			move = ballMoveVector;

			move.Normalize();
			move = transform.TransformDirection (move);
		}

		if(Input.GetMouseButtonDown(1))
		{
			mouseStartpoint = Input.mousePosition;
		}
		/* Calculating mouse drag as an initial step for applying speed to the ball */
		if(Input.GetMouseButtonUp(1))
		{
			mouseEndPoint = Input.mousePosition;
			distance = mouseEndPoint.y - mouseStartpoint.y;
			applySpeed(distance);
			Debug.Log("Mouse distance : " + distance);
		}

		Camera.main.transform.forward = transform.forward;

		base.Update ();
	}

	/**
	 * Function setting initial ball speed 
	 * @Param distance - float, mouse movement on axis Y
	 * 
	 */
	private void applySpeed(float mouseDistance) {
		float speed = mouseDistance / 100.0f;
		base.setballSpeed (speed);
	}
}
