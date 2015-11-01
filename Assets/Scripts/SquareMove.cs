using UnityEngine;
using System.Collections;

public class SquareMove : MonoBehaviour {
	float x = 0f;
	float y = 0f;
	float z = 0f;
	Vector3 move;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (x < 10 && z == 0) {
			x += 0.03f;
			z = 0;
			move = new Vector3 (x, y, z);

		} else {
			x -=0.03f;
			move = new Vector3(x,y,z);
		}
//		if (x == 10) {
//			z +=0.3f;
//
//		}
//
//		if (z == 10 ) {
//			x -= 0.3f;
//		}
//
//		if (z == 0) {
//			z -= 0.3f;
//		}	

		transform.position = move;
	}
}
