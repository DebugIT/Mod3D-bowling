using UnityEngine;
using System.Collections;

/**
 * \author Piotr Mścichowski
 * 
 * \brief Basic class describing prior settings and behaviour of ball.
 */
[RequireComponent(typeof(CharacterController))]
public class Ball : MonoBehaviour {

	/*
     * Speed of movement while making basic moves using keyboard, without collision detection,
     * force(gravity for example) etc.
     */
	float speed = 1.0f;
	
    /*
     * Character controller object chosen to adjust linear move to the ball
     */
	public CharacterController controller;
	
    /*
     * Ball speed before movement
     */
	public float ballSpeed = 0.0f;

	/*
     * Camera turning speed
     */
	public float turnSpeed = 90f;
	
    /*
     * Vector describing ball movement
     */
	protected Vector3 move = Vector3.zero;
	
    /**
     * Sets speed of object
     */
	public virtual void setballSpeed(float newSpeed) {
		this.ballSpeed = newSpeed;
	}
	
	/**
	 * \brief Initializes CharacterController
     *
     * This method uses CharacterComponent to provide basic movement functionality.
     * It is planned to eventually use rigidbody due to force change ability etc.
	 */ 
	public virtual void Start () {
		/**
         * First We want to try movement with character controller but finally probably
         * there will be rigidbody due to force change ability etc.
         */
		controller = GetComponent<CharacterController> ();
		
		if (!controller) {
			Debug.LogError ("Character controller not assigned");
			enabled = false;
		}

		/* script will be executed */
		enabled = true;		
	}
	
	/**
	 * \brief Describes basic control fro keyboard of ball
     *
     * It uses simple move mode. Movement of object is controlled by arrow keys
     * (up, down, left, right). It also adds possibility to restart game by pressing R.
	 */
	public virtual void Update () {
		/**
         * For the begining choosing simple move mode
         */
		controller.SimpleMove(move * ballSpeed );

		if(Input.GetKey(KeyCode.LeftArrow)){
			
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.UpArrow)){
			
			transform.position += Vector3.up * speed * Time.deltaTime;
		}
		
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.position += Vector3.down * speed * Time.deltaTime;	 
		}

		if (Input.GetKey (KeyCode.R)) {
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
