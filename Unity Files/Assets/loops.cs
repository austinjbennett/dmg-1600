using UnityEngine;
using System.Collections;

public class loops : MonoBehaviour {

	// for loop
	// while loop
	// do while loop
	// foreach loop

	int numBoxes = 5;
	int currentBox = 0;
	bool today = true;

	string[] strings = new string[3];


	// Use this for initialization
	void Start () {
		strings [0] = "I'm number one!";
		strings [1] = "I'm number two!";
		strings [2] = "I'm number three!";

		for (int i = 0; i < 6; i++) {
			Debug.Log ("One pass through the loop, this is" + i);
		}
		while (numBoxes > 0) {
			Debug.Log ("You have " + numBoxes + "left");
			numBoxes--;
		}
		do {
			Debug.Log ("The currentBox is" + currentBox);
		} while(today == false);

		foreach (string statement in strings) {
			Debug.Log (statement);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
