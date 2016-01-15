using UnityEngine;
using System.Collections;

public class variablesFunctions : MonoBehaviour {

	int number = 10;

	// Use this for initialization
	void Start () {
		int doubleNumber = multiplyByTwo (number);
		Debug.Log (number);
		Debug.Log (doubleNumber);
	}

	int multiplyByTwo(int anotherNumber){
		int double;
		double = anotherNumber * 2;
		return  double;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
