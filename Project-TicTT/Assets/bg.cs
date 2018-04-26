using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class bg : MonoBehaviour {

	public string WhichKey;	// which key will activate it?

	// sound stuff
	AudioSource audioSource;

	// the renderer for this cube
	public Renderer rend;

	void Start () {

		// at start, get the Renderer component of this object
		// and set it to rend
		rend = GetComponent<Renderer> ();

		// and audio source
		audioSource = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (WhichKey)) {

			// make sure its not already playing
			if (audioSource.isPlaying == false) {
				audioSource.Play ();
			}

			// turn it a different color
			rend.material.color = Color.red;
		} else {
			rend.material.color = Color.white;
		}

	}
}