using UnityEngine;
using System.Collections;

public class Ex2Move : MonoBehaviour {

	float time = 0.0f;
	float z = 2.0f;
	float speed = 2.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		speed = Mathf.Sin (time);

		float x = Mathf.Sin (time*speed);
		float y = Mathf.Cos (time*speed);
		transform.position = new Vector3 (x*2, y*2, z);
	}
}
