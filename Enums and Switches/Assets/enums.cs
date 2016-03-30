using UnityEngine;
using System.Collections;

public class enums : MonoBehaviour {

	public enum Color {red, blue, orange, silver}
	public Color myColor;

	void Start () {
		myColor = Color.blue;

		myColor = whatColor (myColor);
	}

	Color whatColor (Color color) {
		switch (color) {
		case Color.red:
			print ("your color is red");
			break;
		case Color.blue:
			print ("your color is blue");
			color = Color.blue;
			break;
		case Color.orange:
			print ("your color is orange");
			break;
		case Color.silver:
			print ("your color is silver");
			break;
		default:
			print ("your color is unknown");
			break;
		}
		return color;
	}

	// Update is called once per frame
	void Update () {

	}
}
