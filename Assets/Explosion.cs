//using Mono.Cecil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.VFX;
using UnityEngine.UI;
using UnityEngine.VFX;

public class Explosion : MonoBehaviour
{
    

    [SerializeField] private VisualEffect visualEffect;
    [SerializeField, Range (0,100000)] private float SpawnRate=60000;
    [SerializeField] private Gradient Color = null;
    [SerializeField] private Gradient Color02 = null;
    [SerializeField] private Gradient Color03 = null;
    [SerializeField, Range(0, 100f)] private float Tamaño = 1;
    [SerializeField, Range(0, 10000)] private float TrailSpawnRate = 5000;
    [SerializeField] Slider sliderColor;
    [SerializeField] Slider sliderColor02;
    [SerializeField] Slider sliderColor03;
    [SerializeField] Slider sliderSpawnRate;
    [SerializeField] Slider sliderTrailSpawnRate;
    [SerializeField] Slider sliderTamaño;


    // Update is called once per frame
    void Update()
    {
        visualEffect.SetFloat("SpawnRate", SpawnRate);
        visualEffect.SetGradient("Color", Color);
        visualEffect.SetGradient("Color02", Color02);
        visualEffect.SetGradient("Color03", Color03);
        visualEffect.SetFloat("TrailsSpawnRate", TrailSpawnRate);
        visualEffect.SetFloat("Tamaño", Tamaño);
        SpawnRate = sliderSpawnRate.value;
        TrailSpawnRate = sliderTrailSpawnRate.value;
        Tamaño = sliderTamaño.value;
        

    }

}
