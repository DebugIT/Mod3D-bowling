using UnityEngine;
using System.Collections;

/**
 * @Author Piotr Mścichowski
 * 
 * Basic class describing prior settings and behaviour of ball
 * 
 */

[RequireComponent(typeof(CharacterController))]
public class Ball : MonoBehaviour {

	/*Speed of movement while making basic moves using keyboard, without collision detection, force(gravity for example) etc. */
	float speed = 1.0f;
	/*Character controller object chosen to adjust linear move to the ball */
	public CharacterController controller;
	/* ball speed before movement */
	public float ballSpeed = 0.0f;
	/* camera turning speed */
	public float turnSpeed = 90f;
	/*Vector describing ball movement*/
	protected Vector3 move = Vector3.zero;

	public virtual void setballSpeed(float newSpeed) {
		this.ballSpeed = newSpeed;
	}
	
	// Use this for initialization
	/**
	 * @Param none
	 * Initializes character controller
	 */ 
	public virtual void Start () {
		controller = GetComponent<CharacterController> ();
		
		if (!controller) {
			Debug.LogError ("Character controller not assigned");
			enabled = false;
		}
	}
	
	// Update is called once per frame
	/**
	 * @Params none
	 * Describes basic control fro keyboard of ball
	 */
	public virtual void Update () {
		/*For the begining choosing simple move mode */
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
	}

	
}
