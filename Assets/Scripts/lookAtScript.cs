using UnityEngine;
using System.Collections;

/**
 * \author Piotr Mścichowski
 * \date 19.11.2015 created
 * \date 20.11.2015 last updated
 * \brief Camera movement 
 *
 * This script should be attached to player, allows camera to follow object
 * 
 */
public class lookAtScript : MonoBehaviour {

	public Transform target;

	// Use this for initialization
	void Start () {
	
	}

	/**
     * \brief set camera to follow an object
     *
     */
	// Update is called once per frame
	void Update () {
		Camera.main.transform.LookAt (target);
	}
}
