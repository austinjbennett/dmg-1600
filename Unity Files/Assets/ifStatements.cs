using UnityEngine;
using System.Collections;

public class ifStatements : MonoBehaviour {

	int maxNum = 6;
	int currentNum = 0;

	// Use this for initialization
	void Start () {
		if (currentNum == maxNum) {
			Debug.Log('The current number is at the max!');
		}
		else if (currentNum < maxNum) {
			Debug.Log('You\'re not quite at the max yet');
		}
		else {
			Debug.Log('Whoa, you\'ve gone too far dude');
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
