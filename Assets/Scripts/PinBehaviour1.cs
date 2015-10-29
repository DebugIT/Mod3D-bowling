using UnityEngine;
using System.Collections;

public class PinBehaviour1 : MonoBehaviour {

	Rigidbody pinBody;
	Vector3 vecUp;
	// Use this for initialization
	void Start () {
		pinBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		//pinBody.AddRelativeForce (Vector3.left * 2);
		pinBody.MovePosition(transform.position + (-transform.forward) * Time.deltaTime);

		//pinBody.MovePosition (transform.forward * 20);
		//pinBody.MovePosition (transform.position +  (-transform.forward) * 4);

	}
}
