using UnityEngine;
using System.Collections;

/**
 * \author Piotr Mścichowski
 * \date 19.11.2015 created
 * \date 20.11.2015 last updated
 * \brief Class describing jump movement of pin.
 *
 * This script should be attached to pinf prefab. It checks for collision with track(game object with tag called 'track'). 
 * If number of collisions equals set up number, deletes the pin.
 * 
 */
public class JumpingPins : MonoBehaviour {

	Rigidbody body; //!< Body for pin, defines gravidy and basic physics
	public float radius = 3.0f; //!< Radius in which explosion should affect
	public float up; //!< Vector defining upward movement.
	public float force; //!< Force for explosion
	public int maxNumberOfCollisions; //!< Variable definig max number of collision that can occur between objects
	int currentNumberOfCollisions = 0; //!< Current number of collisions
	bool addForce; //!< flag to determine wheter apply explosion force or not

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		/**
			 * Adding explosion force to rigidbody.
			 * First param descibres the force of explosion
			 * Second param describes center of th sphere in which explosion will have effect
			 * Thrid param describes the radius of sphere in which explosion will have effect
			 * Fourth param describes movement up
			 * Fifth param describes type of force applied to an object
			 * After applying force we set flag to false to stop adding force
			 * */
		if(addForce)
			body.AddExplosionForce (force, transform.position, radius, up);
		addForce = false;
	
	}

	/**
     * \brief Collision listener.
     *
     * When collision occurs between 2 specific objects. If current number od collisions is equal to defined max number of collision object is being destroyed.
     * Otherwise current number of collisions is incremented and addForce flag is set to true to allow adding explosion in Update() method.
     */
	void OnCollisionEnter(Collision c) {
		if (c.gameObject.tag == "track") {
			if(currentNumberOfCollisions != maxNumberOfCollisions){		
				addForce = true;
				currentNumberOfCollisions++;
				Debug.Log("Track collision");
			}
			else Destroy(this.gameObject);
		}
	}
}
