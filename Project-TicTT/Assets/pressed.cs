using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressed : MonoBehaviour
{
    public GameObject[] cubes;
    public Renderer rend;

    // Use this for initialization
    void Start()
    {
        rend = GetComponent<Renderer>();
        cubes = GameObject.FindGameObjectsWithTag("Picked");
        for (int i = 0; i < cubes.Length; i++) ;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {

            rend.material.color = Color.blue;
        }

    }
}
