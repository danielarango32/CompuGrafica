using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedControl : MonoBehaviour
{
    private ParticleSystem Sistema;

    public void IncreaseSpeed()
    {
        Sistema = GetComponent<ParticleSystem>();
        Sistema.Stop();

        var particleSettings = Sistema.main;
        particleSettings.startSpeed =+ 10f;

        Sistema.Play();
    }
    public void DecreaseSpeed()
    {
        Sistema = GetComponent<ParticleSystem>();
        Sistema.Stop();

        var particleSettings = Sistema.main;
        particleSettings.startSpeed = -10f;

        Sistema.Play();
    }
}
