using UnityEngine;
using System.Collections;

public class ifStatements : MonoBehaviour {

	int maxNum = 6;
	int currentNum = 7;

	// Use this for initialization
	void Start () {
		if (currentNum == maxNum) {
			Debug.Log ("You are at the max number");
		} else if (currentNum < maxNum) {
			Debug.Log ("You are not quite at the maximum yet");
		} else {
			Debug.Log ("You have surpassed the maximum value");
		}
	}	
	
	// Update is called once per frame
	void Update () {
		
	}
}
