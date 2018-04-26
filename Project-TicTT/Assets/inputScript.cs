using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 [RequireComponent(typeof(AudioSource))]
public class inputScript : MonoBehaviour
{
    public string WhichKey1;
    public string WhichKey2;
    public string WhichKey3; 
    AudioSource audioSource;
    public AudioClip sound1;
    public AudioClip sound2;

   // which key will activate it?

    // sound stuff
    // the renderer for this cube
    public Renderer rend;

    void Start()
    {

        // at start, get the Renderer component of this object
        // and set it to rend
        rend = GetComponent<Renderer>();
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(WhichKey1))
        {   
            if (audioSource.isPlaying == false) {
                audioSource.clip =sound1;
				audioSource.Play ();
			}
            rend.material.color = Color.red;

        }
        if (Input.GetKey(WhichKey2))
        {
            if (audioSource.isPlaying == false) {
            audioSource.clip =sound2;
			audioSource.Play ();
			}
            rend.material.color = Color.blue;
        }
        if (Input.GetKey(WhichKey3))
        {
            rend.material.color = Color.white;
        }
    }
}