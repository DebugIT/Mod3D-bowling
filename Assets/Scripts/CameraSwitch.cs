using UnityEngine;
using System.Collections;

/**
 * \author Marek Nalepa
 * \date 29.10.2015 created
 * 
 * \brief Class for switching cameras.
 *
 * This script should be attached to an empty game object. It listens for function key presses.
 * When keys F1-F3 are pressed, corresponding cameras are activated (so F1 enables first camera,
 * F2 enables second camera and F3 enables third camera).
 */
public class CameraSwitch : MonoBehaviour {

    public Camera[] cameras; //!< Stores all cameras defined in scene
    public int camerasCount; //!< Stores number of all cameras in scene

    /**
     * \brief This method is called on script initialization.
     *
     * In initialization script gets all cameras defined in scene and stores them
     * in variables for future use. When less than three cameras are detected,
     * the script is deactivated.
     */
    void Start () {
        cameras = Camera.allCameras;
        camerasCount = Camera.allCamerasCount;
        if (camerasCount < 3)
            enabled = false;
	}

    /**
     * \brief This method is called for every frame.
     *
     * This script works when user presses any of the F1, F2 and F3 keys.
     * Method checks which one of these keys is pressed. First it has
     * to deactivate all cameras and activate only one, corresponding
     * to pressed key.
     */
    void Update () {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            deactivateCameras();
            cameras[0].enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.F2))
        {
            deactivateCameras();
            cameras[1].enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.F3))
        {
            deactivateCameras();
            cameras[2].enabled = true;
        }
    }

    /**
     * \brief Helper method to deactivate all cameras
     *
     * Method iterates over array of all detected cameras
     * and sets 'enabled' flag to false for each of them.
     */
    private void deactivateCameras() {
        for (int i = 0; i < camerasCount; ++i)
            cameras[i].enabled = false;
    }
}
