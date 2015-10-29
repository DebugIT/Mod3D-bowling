using UnityEngine;
using System.Collections;

/**
 * \author Marek Nalepa
 * 
 * \brief Class for controlling object's color change.
 *
 * This script can be attached to any game object. It provides possibility to change color
 * of object on pressing space key.
 */
public class ColorChange : MonoBehaviour {

    /**
     * GameObject's Renderer
     */
    public Renderer ren;

    /**
     * Set of possible colors
     */
    public Color[] possibleColors = {
        Color.black,
        Color.blue,
        Color.cyan,
        Color.gray,
        Color.green,
        Color.magenta,
        Color.red,
        Color.white,
        Color.yellow
    };

    /**
     * Index of next color to assign
     */
    public int nextColor;

	/**
     * \brief This method is called on script initialization.
     *
     * In initialization script aquires game object renderer and stores
     * its reference to future use. Furthermore, the next color index is
     * set to zero.
     */
	public void Start () {
        ren = gameObject.GetComponent<Renderer>();
        if (!ren)
        {
            Debug.LogWarning("Renderer is not assigned to object!");
            /**
             * Prevents script from running
             */
            enabled = false;
        }

        enabled = true;
        nextColor = 0;
	}
	
	/**
     * \brief This method is called for every frame.
     *
     * Scripts works when user presses space key. This method checks if
     * space key is pressed down in current frame and assigns next color from
     * array. It also increments next color index. Method does not change
     * colors continuously while user holds space down, only when he first press it.
     */
	public void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ren.material.color = possibleColors[nextColor];
            ++nextColor;
            nextColor %= possibleColors.Length;
        }
    }
}
