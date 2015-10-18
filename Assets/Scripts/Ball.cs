using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]

public class Ball : MonoBehaviour {
	float speed = 1.0f;
	public float thrust;
	public Rigidbody rb;
	protected CharacterController controller;

	public float moveSpeed = 2f;
	public float turnSpeed = 90f;
	
	protected Vector3 move = Vector3.zero;
	
	// Use this for initialization
	public virtual void Start () {
		controller = GetComponent<CharacterController> ();
		
		if (!controller) {
			Debug.LogError ("Character controller not assigned");
			enabled = false;
		}
		//rb = gameObject.AddComponent<Rigidbody> ();
		//rb = GetComponent<Rigidbody>();
	}
	
	public virtual void FixedUpdate() {
	}
	
	// Update is called once per frame
	public virtual void Update () {

		controller.SimpleMove(move );

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
		if (Input.GetKey (KeyCode.W)) {
			//rb.AddForce (transform.forward * thrust, ForceMode.Impulse)

		}
		
	}
	
}
