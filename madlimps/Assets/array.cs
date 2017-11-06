using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour {

	public string [] names;
	public string [] places;
	public string [] phrases;

	void Start () {
	
		// for(int i = 0; i <names.Length; i++){
		// Debug.Log(names[i]);
		//}
		
		 int randNam = Random.Range(0, names.Length);
		 int randPlac = Random.Range(0, places.Length);
		 int phrase = Random.Range(0, phrases.Length);

		 string line1 = "Are you the "+ names [Random.Range(0,names.Length)]+ " , "+ places [Random.Range(0,places.Length)]+" , "+ phrases [Random.Range(0,phrases.Length)]+"?";
		 Debug.Log(line1);




		
	}
		void Update () {
		
	}
}
