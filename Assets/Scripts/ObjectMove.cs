using UnityEngine;
using System.Collections;

public class ObjectMove : MonoBehaviour {

    public Renderer ren;

    void Start () {
        ren = GetComponent<Renderer>();
	}

    void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            ren.material.color = Color.black;
            // Change color
        }
        if (Input.GetMouseButton(1))
        {
            Vector3 position = gameObject.transform.position;
            const float speed = 0.05f;
            float translateX = Input.GetAxis("Mouse X") * speed;
            float translateY = Input.GetAxis("Mouse Y") * speed;
            position.x += translateX;
            position.y += translateY;
            gameObject.transform.position = position;
        }
	}
}
