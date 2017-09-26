using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour {

    public GameObject go;
    public GameObject go2;
    public GameObject go3;
    public GameObject go4;

    public KeyCode F2;
    public KeyCode F1;
    public KeyCode F4;
    public KeyCode F3;



    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown(F2))
              Instantiate(go, transform.position, Quaternion.identity);
        if (Input.GetKeyDown(F1))
            Instantiate(go2, transform.position, Quaternion.identity);
        if (Input.GetKeyDown(F3))
            Instantiate(go3, transform.position, Quaternion.identity);
        if (Input.GetKeyDown(F4))
            Instantiate(go4, transform.position, Quaternion.identity);


    }
}