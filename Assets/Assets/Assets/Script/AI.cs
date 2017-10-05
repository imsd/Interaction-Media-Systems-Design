using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

	public GameObject goo;

	public float sensorL = 1.0f;
	public float speed = 15.0f;
	public float directionVal = 3.0f;
	public float turnVal = Random.Range(1.0f,5.0f);
	public float turnSp = 50.0f;

	Collider myCollider;

	// Use this for initialization
	void Start () {
		myCollider = transform.GetComponent<Collider>();

	}

	void OnCollisionEnter(Collision coll) {
		//Destroy (coll.gameObject);
	
		coll.gameObject.transform.localScale += new Vector3 (1 ,1, 1);

		Destroy(this.gameObject);

	
	}

	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		int flag = 0;
		//Right
		if( Physics.Raycast(transform.position, transform.right, out hit,(sensorL + transform.localScale.x))){
			if(hit.collider.tag != "Obstable" || hit.collider == myCollider){
				return;
			}
			turnVal -= 3;
			flag++;
		}
		//Left
		if( Physics.Raycast(transform.position, - transform.right, out hit,(sensorL + transform.localScale.x))){
			if(hit.collider.tag != "Obstable" || hit.collider == myCollider){
				return;
			}
			turnVal += 3;
			flag++;
		}
		//Front
		if( Physics.Raycast(transform.position, transform.forward, out hit,(sensorL + transform.localScale.z))){
			if(hit.collider.tag != "Obstable" || hit.collider == myCollider){
				return;
			}

			if(directionVal == 3.0f){
				directionVal = -3;
			}
			flag++;
		}

		//back
		if( Physics.Raycast(transform.position,- transform.forward, out hit,(sensorL + transform.localScale.z))){
			if(hit.collider.tag != "Obstable" || hit.collider == myCollider){
				return;
			}
			if(directionVal == -3.0f){
				directionVal = 3;
			}
			flag++;

		if(flag ==0){
			turnVal =0;
		}
	}

		transform.Rotate(Vector3.up* (turnSp * turnVal ) *Time.deltaTime);

		transform.position += transform.forward * (speed*directionVal) * Time.deltaTime; 
	}


	void OnDrawGizmo(){

		Gizmos.DrawRay(transform.position,-transform.forward * (sensorL + transform.localScale.z));
		Gizmos.DrawRay(transform.position,transform.forward * (sensorL + transform.localScale.z));
		Gizmos.DrawRay(transform.position,-transform.forward * (sensorL + transform.localScale.x));
		Gizmos.DrawRay(transform.position,transform.right * (sensorL + transform.localScale.x));
	}

	

}

	
