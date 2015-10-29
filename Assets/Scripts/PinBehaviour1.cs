using UnityEngine;
using System.Collections;

public class PinBehaviour1 : MonoBehaviour {

	Rigidbody pinBody;
	Vector3 vecUp;
	// Use this for initialization
	void Start () {
		pinBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (vecUp.y <= 10 && vecUp.y >= 0) {
			vecUp = Vector3.up * 2;
		}

		if (vecUp.y < 0 && vecUp.y > 10) {
			vecUp = Vector3. down * 2;
		}

		pinBody.MovePosition (transform.position +  (-transform.forward) * 4);

	}
}
