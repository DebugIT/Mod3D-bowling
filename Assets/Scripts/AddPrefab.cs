using UnityEngine;
using System.Collections;

/**
 * \author Marek Nalepa
 * \date 19.11.2015 created
 * \brief Class for adding prefabs pins.
 *
 * This script should be attached to prefab game object. 
 * It waits for key button A, when it's pressed then prefab is added and destroyed 3s after being created to save memory.
 *
 */
public class AddPrefab : MonoBehaviour {

	// Use this for initialization
	public GameObject prefab;
	GameObject prefabClone;
	void Start() {

	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			prefabClone = Instantiate(prefab, transform.position, Quaternion.identity) as GameObject;
			Destroy(prefabClone,3); // destory after 3 s
		}
	}
}
