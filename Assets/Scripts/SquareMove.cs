using UnityEngine;
using System.Collections;

/**
 * \author Marek Nalepa
 * \date 04.11.2015 created
 * 
 * \brief Script for moving object along square.
 *
 * Square movement can be described by four parts: two on one axis (there and back)
 * and two on another. This script runs in 4 different modes, changing them on time basis.
 * Each mode moves object in one direction on one axis.
 */
public class SquareMove : MonoBehaviour {
    float time = 0.0f;
    int mode = 0;

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
     * On each call, method gets game object's position and changes it properly.
     * In first mode, object is moved along Z axis by positive values. In second - along
     * X axis by positive values. In third - again along Z axis, but by negative values.
     * In fourth - again along X axis, but by negative values.
     */
    void Update () {
        Vector3 position = gameObject.transform.position;
        time += Time.deltaTime;
        switch (mode)
        {
            case 0:
                position.z += Time.deltaTime;
                if (time >= 3.0f)
                    mode = 1;
                break;
            case 1:
                position.x += Time.deltaTime;
                if (time >= 6.0f)
                    mode = 2;
                break;
            case 2:
                position.z -= Time.deltaTime;
                if (time >= 9.0f)
                    mode = 3;
                break;
            case 3:
                position.x -= Time.deltaTime;
                if (time >= 12.0f)
                {
                    mode = 0;
                    time = 0.0f;
                }
                break;
        }
        gameObject.transform.position = position;
	}
}
