using UnityEngine;
using System.Collections;

public class PinFallDown : MonoBehaviour {

	Rigidbody body;
	public float radius = 2.0F;
	public float power = 10.0F;
	Vector3 position;
	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody> ();
		position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.J)) {
			body.AddExplosionForce(power, position, radius, 3.0F);
			//body.AddForce(-transform.right, ForceMode.Impulse);
		}
	}
}
