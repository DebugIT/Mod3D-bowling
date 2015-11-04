using UnityEngine;
using System.Collections;

/**
 * Script describing circular movement of pin
 * @Author Piotr Mścichowski
 * @Date 29.10.2015
 * 
 * X axis values calculated from sinus function
 * Y axis values calculated from cosinus function
 * */
public class CircularPinMove : MonoBehaviour {

	float time = 0.0f;
	float z = 2.0f;
	float speed = 2.0f;
	Vector3 vecUp;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime; // delta time used to be frame rate independent
		float x = Mathf.Sin (time*speed);
		float y = Mathf.Cos (time*speed);
		//now we want to change object position
		transform.position = new Vector3 (x*2, y*2, z);
		
		//pinBody.MovePosition(transform.position + (-transform.forward) * Time.deltaTime);

	}
}
