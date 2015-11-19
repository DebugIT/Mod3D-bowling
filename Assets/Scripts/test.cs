using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	public Rigidbody body;

	public float force = 1;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		body.AddForce (Vector3.forward * force);
	}
}
