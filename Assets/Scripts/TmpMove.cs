using UnityEngine;
using System.Collections;

public class TmpMove : MonoBehaviour {

	public Rigidbody body;
	bool applyForce = true;
	public bool moveLeft;
	public bool moveRight;
	public float radius = 3.0f;
	public float up = 100.0f;
	public float force = 10.0f;
	
	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody> ();
		//body.AddExplosionForce (force, transform.position, radius, up);
	}
	
	// Update is called once per frame
	void Update () {
		if (applyForce) {
			if (moveLeft && !moveRight)
				body.AddForce (Vector3.left * force);
			else if (!moveLeft && moveRight)
				body.AddForce (Vector3.right * force);
		}
	}

	void OnCollisionEnter(Collision c) {
		if (c.gameObject.tag == "pin") {
			Debug.Log("Pinn colision");
			body.AddExplosionForce(force,Vector3.left, radius, up);
			applyForce = false;
			              
		}
	
		if (c.gameObject.tag == "track") {
			Debug.Log("kolizja z track");
			body.AddExplosionForce(force, transform.position, radius, up);
		}

	}
}
