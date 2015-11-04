using UnityEngine;
using System.Collections;

/**
 * Script for task 2 subtask 2, circular movement with fixed speed based on sinus 
 * @Author Piotr Mścichowski
 * @Date 29.10.2015 created
 * @Date 03.11.2015 last modified
 * */
public class Ex2Move : MonoBehaviour {

	float time = 0.0f;
	float z = 2.0f;
	float speed = 2.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	// Function the same as in circular movement but speed depends on sinus value of delta time - time complete last frame it took
	void Update () {
		time += Time.deltaTime;
		speed = Mathf.Sin (time);

		float x = Mathf.Sin (time*speed);
		float y = Mathf.Cos (time*speed);
		transform.position = new Vector3 (x*2, y*2, z);
	}
}
