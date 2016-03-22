using UnityEngine;
using System.Collections;

public class classesAndDataTypes : MonoBehaviour {

	public class Donut {

		string icing;
		string flavor;
		bool sprinkles;

		public Donut() {

			icing = "chocolate";
			flavor = "vanilla";
			sprinkles = true;
		}

		public Donut(string ic, string fl, bool sp) {
			icing = ic;
			flavor = fl;
			sprinkles = sp;
		}

	}

	Donut chocolate = new Donut();
	Donut maple = new Donut("maple", "vanilla", false);

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
