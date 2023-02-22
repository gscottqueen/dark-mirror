using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorComponent : MonoBehaviour
{
    private Vector3 rotationAxis = Vector3.up;
    public float rotationSpeed = .1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationAxis, rotationSpeed);
    }
}
