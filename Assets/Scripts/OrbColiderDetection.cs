using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbColiderDetection : MonoBehaviour
{
    private Color platformButtonColor;
    private Color orbColor;
    private Component[] orbComponents;
    private void Start()
    {
        platformButtonColor = gameObject.GetComponent<MeshRenderer>().material.color;
    }
    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Orb"))
        {
            // retuns all our children of the current component
            orbComponents = other.GetComponentsInChildren<MeshRenderer>();

            foreach (MeshRenderer childComponents in orbComponents)
            {
                if (childComponents.CompareTag("OrbChild"))
                {
                    orbColor = childComponents.material.color;
                }
            }

            if (platformButtonColor.Equals(orbColor))
            {
                gameObject.BroadcastMessage("EnergyPlumeOn", platformButtonColor);
                Debug.Log("PlatformButton Collision");
            }
        }

    }


    // OnTriggerExit is called when the Collider other has stopped touching the trigger
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Orb"))
        {
            gameObject.BroadcastMessage("EnergyPlumeOff", platformButtonColor);
            Debug.Log("PlatformButton Collision");
        }

    }
}