using UnityEngine;
using System.Collections;

/**
 * \author Piotr Mścichowski
 * \date 29.10.2015 created
 *
 * \brief Script describing circular movement of pin
 * 
 * This script uses X axis values calculated from sinus function
 * and Y axis values calculated from cosinus function.
 */
public class CircularPinMove : MonoBehaviour {

	float time = 0.0f; //!< calculates overall time
	float z = 2.0f; //!< position on Z axis
	float speed = 2.0f; //!< movement speed coefficient

    /**
     * \brief This method is called on script initialization.
     *
     * Empty (not used by script)
     */
    void Start () {
    }

    /**
     * \brief This method is called for every frame.
     *
     * It calculates values of sinus and cosinus in basis of time units to properly
     * determine translation of object to simulate movement along circle.
     */
    void Update() {
        time += Time.deltaTime; //!< delta time used to be frame rate independent
        float x = Mathf.Sin(time * speed);
        float y = Mathf.Cos(time * speed);
        //now we want to change object position
        transform.position = new Vector3(x * 2, y * 2, z);
    }
}
