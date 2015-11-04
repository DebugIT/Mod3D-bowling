using UnityEngine;
using System.Collections;

/**
 * \author Piotr Mścichowski
 * \date 30.10.2015 created
 * \date 04.11.2015 last edited
 * 
 * \brief Class discribing explosion of bowling pins connected with key event
 * 
 * This script adds explosion force to game object to move it.
 */
public class PinFallDown : MonoBehaviour {

	Rigidbody body; //!< Rigidbody member of game object
	public float radius = 2.0F; //!< Radius of sphere where script takes effect
	public float power = 50.0F; //!< Force of explosion
	Vector3 position; //!< extracted position of game object

    /**
     * \brief This method is called on script initialization.
     *
     * In initialization script gets Rigidbody component from game object
     */
    void Start () {
		body = GetComponent<Rigidbody> ();
	}

    /**
     * \brief This method is called for every frame.
     *
     * This method adds force to rigidbody.
     */
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
