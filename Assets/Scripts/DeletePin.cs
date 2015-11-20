using UnityEngine;
using System.Collections;

/**
 * \author Marek Nalepa
 * \date 18.11.2015 created
 * \date 20.11.2015 last updated
 * \brief Class for deleting pins.
 *
 * This script should be attached to floor under track. It checks for collision with game object thath has tag named 'pin'.
 *
 */
public class DeletePin : MonoBehaviour {

	GameObject obj;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	}
	// Collision handler
	void OnCollisionEnter (Collision c)
	{
		if (c.gameObject.tag == "pin") {
			Destroy(c.gameObject);
		}

	}
}
