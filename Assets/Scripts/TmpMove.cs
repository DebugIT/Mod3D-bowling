using UnityEngine;
using System.Collections;

public class TmpMove : MonoBehaviour {

	public Rigidbody body;
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
		if(moveLeft && !moveRight)
			body.AddForce (Vector3.left * force);
		else if (!moveLeft && moveRight)
			body.AddForce (Vector3.right * force);
	}

	void OnCollisionEnter(Collision c) {
		if (c.gameObject.tag == "pin") {
			Debug.Log("Pinn colision");
			body.AddForce(Vector3.forward *force);
		//	body.AddExplosionForce (force, c.gameObject.transform.position, radius, up);
		}
	}
}
