using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	public float StartSpwn = 1.0f;
	public float SpawnFreq = 0.5f;


	/* add a gameobject to the insepctor 
	that we  can access in this script */

	public GameObject go;

	// Use this for initialization
	void Start () {

		InvokeRepeating ("SpawnThings", StartSpwn, SpawnFreq);

		
	}
	
	// Update is called once per frame
	void SpawnThings () {

		transform.position = new Vector3 (Random.Range(-5f,5f), 3 ,Random.Range(-5f,5f));

		Instantiate (go, transform.position, Quaternion.identity);
		
	}
}
