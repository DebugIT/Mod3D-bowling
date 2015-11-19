using UnityEngine;
using System.Collections;

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
