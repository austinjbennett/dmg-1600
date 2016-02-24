using UnityEngine;
using System.Collections;

public class scope2 : MonoBehaviour {

	private scopeAndAccessModifiers myOtherClass;


	// Use this for initialization
	void Start () {
		myOtherClass = new scopeAndAccessModifiers();
		Debug.Log ("You have " + myOtherClass.numTwo + myOtherClass.apple + "Apples");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
