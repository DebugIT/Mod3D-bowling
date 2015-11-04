using UnityEngine;
using System.Collections;

/**
 * @Author Piotr Mścichowski
 * @Date 30.10.2015 created
 * @Date 04.11.2015 last edited
 * 
 * Class discribing explosion of powling pins connected with key event
 * */
public class PinFallDown : MonoBehaviour {

	Rigidbody body;
	public float radius = 2.0F;
	public float power = 50.0F;
	Vector3 position;
	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.J)) {
			position = transform.position;

			/**
			 * Adding force to rigidbody.
			 * First param descibres the force of explosion
			 * Second param describes center of th sphere in which explosion will have effect
			 * Thrid param describes the radius of sphere in which explosion will have effect
			 * Fourth param describes movement up
			 * Fifth param describes type of force applied to an object
			 * */
			body.AddExplosionForce(power,position , radius, 10.0f, ForceMode.Acceleration);
		}
	}
}
