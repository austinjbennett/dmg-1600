using UnityEngine;
using System.Collections;

public class arrays : MonoBehaviour {

	public string[] cars = new string[3];
	//string[] cars = { "bmw", "hyundai", "volkswagen" };


	// Use this for initialization
	void Start () {
		cars [0] = "bmw";
		cars [1] = "hyundai";
		cars [2] = "volkswagen";

		for (int i = 0; i < cars.Length; i++) {
			Debug.Log (cars [i]);
		}
	}


	
	// Update is called once per frame
	void Update () {
	
	}
}
