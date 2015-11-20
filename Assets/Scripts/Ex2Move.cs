using UnityEngine;
using System.Collections;

/**
 * \author Piotr Mścichowski
 * \date 29.10.2015 created
 * \date 03.11.2015 last modified
 *
 * \brief Script describing circular movement of pin with variable speed
 *
 * This script uses X axis values calculated from sinus function
 * and Y axis values calculated from cosinus function. Additionaly, the movement speed
 * is calculated from time, so it changes during movement.
 */
public class Ex2Move : MonoBehaviour {

    float time = 0.0f; // !< calculates overall time
    float z = 2.0f; // !< position on Z axis
    float speed = 2.0f; // !< movement speed coefficient

    /**
     * \brief This method is called on script initialization.
     *
     * Empty (not used by script)
     */
    void Start()
    {
    }

    /**
     * \brief This method is called for every frame.
     *
     * Speed of movement is sinus function of time argument, so it changes during movement.
     * Method calculates values of sinus and cosinus in basis of time units to properly
     * determine translation of object to simulate movement along circle.
     */
    void Update () {
		time += Time.deltaTime; // !< delta time used to be frame rate independent
        speed = Mathf.Sin (time);

		float x = Mathf.Sin (time*speed);
		float y = Mathf.Cos (time*speed);
		transform.position = new Vector3 (x*2, y*2, z);
	}
}
