using UnityEngine;
using System.Collections;

public class BallMovement : Ball {

	Vector3 start = Vector3.zero;
	Vector3 end = Vector3.zero;
	// Use this for initialization
	public override void Start () {
		base.Start ();
	}

	// Update is called once per frame
	public override void Update () {
		//test ();

		if (Input.GetMouseButton (0)) {
			transform.Rotate (0f, Input.GetAxis ("Mouse X") * turnSpeed * Time.deltaTime, 0f);
		}

		if (Input.GetMouseButton (1)) {
		
				Vector3 moveStrength = new Vector3(0F, 0f,Mathf.Abs(-Input.GetAxis("Mouse X")) * Mathf.Abs(-Input.GetAxis("Mouse X")) * Time.deltaTime);
			move = moveStrength;

			move.Normalize();
			move = transform.TransformDirection (move);
		}



		//transform.Rotate (0f, Input.GetAxis ("Mouse X") * turnSpeed * Time.deltaTime, 0f);

		//Vector3 moveStrength = new Vector3(Input.GetAxis("Mouse X") * turnSpeed * Time.deltaTime, 0f);

		Camera.main.transform.forward = transform.forward;

		//move = new Vector3(Input.GetAxis ("Horizontal"), 0f, Input.GetAxis ("Vertical"));
		
		//move.Normalize();
		
		//move = transform.TransformDirection (move);


		base.Update ();
	}

	/*void test() {
		RaycastHit hit = new RaycastHit();
		Vector3 distance = Vector3.zero;
		
		if (Input.GetMouseButtonDown (0)) {
			if (Physics.Raycast (camera.ScreenPointToRay (Input.mousePosition), hit)) {
				start = hit.point;
			}
		}
		
		if (Input.GetMouseButtonUp (0)) {
			if (Physics.Raycast (camera.ScreenPointToRay (Input.mousePosition), hit)) {
				end = hit.point;
				distance = end - start;
				Debug.Log ("Distance in X = " + Mathf.Abs (distance.x));
			}
		}
	}*/
}
