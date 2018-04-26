using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbit : MonoBehaviour {
	public GameObject planet1;
	public float speed;

	// Use this for initialization
	void Start () {
		orbitAround(); 
	}
	
	// Update is called once per frame
	void orbitAround () {
		transform.RotateAround (planet1.transform.position, Vector3.right, speed * Time.deltaTime);
	}
}
