using UnityEngine;
using System.Collections;

public class ExplodeScript : MonoBehaviour {

	Rigidbody rb;

	public float force;
	public float radius;
	public float up;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision c) {
		if (c.gameObject.tag == "Player") {
			rb.AddExplosionForce(force, c.gameObject.transform.position, radius, up);
		}
	}
}
