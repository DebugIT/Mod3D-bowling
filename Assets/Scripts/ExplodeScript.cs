using UnityEngine;
using System.Collections;

/**
 * \author Piotr Mścichowski
 * \date 19.11.2015 created
 * \date 20.11.2015 last updated
 * \brief Class describing pins movement when hitted by ball
 *
 * This script should be attached to prefab. It checks for collision with ball(game object with tag called 'Player'). 
 * 
 */
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

	/**
	* Adding explosion force to rigidbody.
	* First param descibres the force of explosion
	* Second param describes center of th sphere in which explosion will have effect
	* Thrid param describes the radius of sphere in which explosion will have effect
	* Fourth param describes movement up
	* Fifth param describes type of force applied to an object
	* 
	* */
	void OnCollisionEnter(Collision c) {
		if (c.gameObject.tag == "Player") {
			rb.AddExplosionForce(force, c.gameObject.transform.position, radius, up);
		}
	}
}
