using UnityEngine;
using System.Collections;

public class variablesFunctions : MonoBehaviour {

	int myInt = 5;

	// Use this for initialization
	void Start () {
		int newInt = multiplyByTwo(myInt);
		Debug.Log (newInt);
	}

	int multiplyByTwo(int number){
		int newNum;
		newNum = number * 2;
		return newNum;
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
