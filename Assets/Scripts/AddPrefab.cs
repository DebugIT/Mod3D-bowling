using UnityEngine;
using System.Collections;

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
