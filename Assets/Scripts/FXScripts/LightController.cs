using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light fireLight;
public bool isBurning = false;
    public float timeDelay;
    float startTime;

    public bool changeRange = false;
    public float maxRange = 20.0f;
    public float rangeSpeed = 1.0f;
    public bool changeIntensity = false;
    public float maxIntensity = 1.50f;
    public float intensitySpeed = 5.0f;


    //float randomRange = Random.Range(0, 5);
  public float randomSpeed = Random.Range(5.0f, 10.0f);
    //loat randomItensity = Random.Range(0, 3.0f);



//public float randomItensity = Random.Range(0, 3.0f);

    public bool changeColor = false;
    public float colorSpeed = 1.0f;
    public Color startColor;
    public Color endColor;

    void Start () {
        this.gameObject.GetComponent<Light>();
        startTime = Time.time;
    }

    void Update()
    {
        if (changeRange) {
            fireLight.range = Mathf.PingPong(Time.time * rangeSpeed, maxRange);
        }

        if (changeIntensity) {
            fireLight.intensity = Mathf.PingPong(Time.time * rangeSpeed, maxIntensity);
        }
        
        if (changeColor) {
            float t = (Mathf.Sin(Time.time - startTime * colorSpeed));
            fireLight.color = Color.Lerp(startColor, endColor, t);
        }


        
        if (isBurning == false)
        {
            StartCoroutine(FireLight());
        }
        
        
    }
    IEnumerator FireLight() {
        isBurning = true;
        //turn off light
        this.gameObject.GetComponent<Light>().enabled = false;
        timeDelay = Random.Range(0.01f, 0.05f);
        yield return new WaitForSeconds(timeDelay);
        this.gameObject.GetComponent<Light>().enabled = true;
        timeDelay = Random.Range(0.01f, 1.55f);
        yield return new WaitForSeconds(timeDelay);
        isBurning = false;
    }
}

