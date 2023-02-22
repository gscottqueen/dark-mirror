using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FloatComponent : MonoBehaviour
{
    // controls the amplitude of our sin wave
    private float amp = 2;

    void Update()
    {
        // transform our posistion in the y vector by a value of time for up and down movement
        transform.position = new Vector3(0, Mathf.Sin(Time.time) + amp, 0);
    }
}
