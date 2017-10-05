using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour
{

    public GameObject RollSphere;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - RollSphere.transform.position;
    }

    void LateUpdate()
    {
        transform.position = RollSphere.transform.position + offset;
    }
}