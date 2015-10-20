using UnityEngine;
using System.Collections;

public class ColorChange : MonoBehaviour {

    public Renderer ren;

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

    public int currentColor;

	// Use this for initialization
	void Start () {
        ren = gameObject.GetComponent<Renderer>();
        if (!ren)
        {
            Debug.LogWarning("Renderer is not assigned to object!");
        }

        currentColor = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) && ren)
        {
            ren.material.color = possibleColors[currentColor];
            ++currentColor;
            currentColor %= possibleColors.Length;
        }
    }
}
