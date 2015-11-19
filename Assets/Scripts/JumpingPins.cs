using UnityEngine;
using System.Collections;

public class JumpingPins : MonoBehaviour {

	Rigidbody body;
	public float radius = 3.0f;
	public float up;
	public float force;
	public int maxNumberOfCollisions;
	int currentNumberOfCollisions = 0;
	bool addForce;
	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(addForce)
			body.AddExplosionForce (force, transform.position, radius, up);
		addForce = false;
	
	}

	void OnCollisionEnter(Collision c) {
		if (c.gameObject.tag == "track") {
			if(currentNumberOfCollisions != maxNumberOfCollisions){		
				addForce = true;
				currentNumberOfCollisions++;
				Debug.Log("Track collision");
			}
			else Destroy(this.gameObject);
		}
	}
}
