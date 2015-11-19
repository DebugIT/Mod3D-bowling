using UnityEngine;
using System.Collections;

public class superScript : MonoBehaviour {

	public Rigidbody rb;
	public float force = 1;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.AddForce (Vector3.forward * force);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
