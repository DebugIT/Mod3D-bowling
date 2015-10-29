using UnityEngine;
using System.Collections;

/**
 * \author Piotr Mścichowski
 * 
 * \brief Derived class for extended controlling ball movement.
 *
 * This class enhances ball movement control by adding possibility to control movement
 * by mouse, not only keyboard.
 */
public class BallMovement : Ball {

    /**
     * Stores mouse position while starting movement with key pressed.
     */
	private Vector3 mouseStartpoint;

    /**
     * Stores mouse position on key up.
     */
	private Vector3 mouseEndPoint;

    /**
     * Distance
     */
	private float distance;
	private float mouseButtonPressedTime = 0.0f;
	private float totalButtonPressedTime = 0.0f;

	/**
     * It simply calls parent method.
     */
	public override void Start () {
		base.Start ();
	}

    /**
     * \brief This method is called for every frame.
     *
     * If left mouse button is pressed, mouse controls direction in which ball aims.
     * When right mouse key goes down, it stores initial mouse position and starting time.
     * When it goes up, final mouse position is stored and time difference is calculated.
     * Calculated values are then applied to ball movement controller. 
     */
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
			mouseButtonPressedTime = Time.time;
		}
		/* Calculating mouse drag as an initial step for applying speed to the ball */
		if(Input.GetMouseButtonUp(1))
		{
			mouseEndPoint = Input.mousePosition;
			distance = mouseEndPoint.y - mouseStartpoint.y;
			applySpeed(distance);
			Debug.Log("Mouse distance : " + distance);
			totalButtonPressedTime = Time.time - mouseButtonPressedTime;
			mouseButtonPressedTime = 0.0f;
			Debug.Log("Mouse ppm pressed for : " + totalButtonPressedTime);
		}

		Camera.main.transform.forward = transform.forward;

		base.Update ();
	}

	/**
	 * Function setting initial ball speed 
	 * @Param distance - float, mouse movement on axis Y
	 */
	private void applySpeed(float mouseDistance) {
		float speed = mouseDistance / 100.0f;
		base.setballSpeed (speed);
	}
}
