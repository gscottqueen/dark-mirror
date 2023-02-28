using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class PlatformButtonBehavior : MonoBehaviour
{
    // Enter
    public void EnergyPlumeOn(Color color)
    {
        GameObject[] energyPlumes = GameObject.FindGameObjectsWithTag("Energy");

        for (int i = 0; i < energyPlumes.Length; i++)
        {
            ParticleSystem particles;
            particles = energyPlumes[i].GetComponent<ParticleSystem>();
            var main = particles.main;
            // decimals vary in the 1000 so we round here for more consistency
            var color1r = Math.Round(color.r, 2);
            var color2r = Math.Round(main.startColor.color.r, 2);
            var color1g = Math.Round(color.g, 2);
            var color2g = Math.Round(main.startColor.color.g, 2);
            var color1b = Math.Round(color.b, 2);
            var color2b = Math.Round(main.startColor.color.b, 2);

            if ((color1r == color2r) && (color1g == color2g) && (color1b == color2b))
            {
                var emission = particles.emission;
                emission.enabled = true;
            }
        }
    }

    // Exit
    public void EnergyPlumeOff(Color color)
    {
        GameObject[] energyPlumes = GameObject.FindGameObjectsWithTag("Energy");

        for (int i = 0; i < energyPlumes.Length; i++)
        {
            ParticleSystem particles;
            particles = energyPlumes[i].GetComponent<ParticleSystem>();
            var main = particles.main;
            // decimals vary in the 1000 so we round here for more consistency
            var color1r = Math.Round(color.r, 2);
            var color2r = Math.Round(main.startColor.color.r, 2);
            var color1g = Math.Round(color.g, 2);
            var color2g = Math.Round(main.startColor.color.g, 2);
            var color1b = Math.Round(color.b, 2);
            var color2b = Math.Round(main.startColor.color.b, 2);

            if ((color1r == color2r) && (color1g == color2g) && (color1b == color2b))
            {
                var emission = particles.emission;
                emission.enabled = false;
            }
        }
    }
}
