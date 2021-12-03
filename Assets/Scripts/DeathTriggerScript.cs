using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTriggerScript : MonoBehaviour
{

    // added by Max
    //private FireScale fireScale;
    private Shake shake;
    private Light fireLight;
    private LightController intensityAnim;
    public AudioSource fireSound;
    //private FireSound fireSound;

    
    private void Start(){
    shake = GameObject.FindGameObjectWithTag("shakeDeath").GetComponent<Shake>();
    intensityAnim = GameObject.FindGameObjectWithTag("fireLight").GetComponent<LightController>();
    fireSound = GameObject.Find("objDeath01").GetComponent<AudioSource>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        shake.CamShakeDeath();
        intensityAnim.LightFireIntensity();
        //fireSound.Play();
        Debug.Log("Collision Deathtrigger");
        fireSound.Play();

        Destroy(collision.gameObject);
        Score.lifes--;
        Score.score--;
    }
}
 