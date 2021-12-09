using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{

    public float intensity = 1f;
    public float intensitySpeed = 5.0f;
    public float speedTime = 1.0f;
    public float time;
    public float startingIntensity;
    public Light fireLight;

void Start()
{
    fireLight = GetComponent<Light>();
    startingIntensity = fireLight.intensity;

}
void Update()
{
    time += Time.deltaTime * (1 - Random.Range(-speedTime, speedTime)) * Mathf.PI;
    fireLight.intensity = startingIntensity + Mathf.Sin(time * intensitySpeed) * intensity;

}




}