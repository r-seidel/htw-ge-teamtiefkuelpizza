using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTriggerScript : MonoBehaviour
{
    public GameObject missed;
    public CameraShake cameraShake;
    public float removedlife = 0f;
    public LightController lightFire;

   public int RndNumber;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score--;
        RndNumber = Random.Range(1,3);
        //shake.CamShakeDeath();
        //intensityAnim.LightFireIntensity();   TODO: fix
        //fireSound.Play();
        Debug.Log("Collision Deathtrigger");
        //fireSound.Play();

        Destroy(collision.gameObject);
        missed.GetComponent<LifeScript>().RemoveLife();
        removedlife++;
        if (removedlife == 2f) {
                    FindObjectOfType<AudioManager>().Play("audioHeartBeat");


        }
       
        FindObjectOfType<AudioManager>().Play("audioFire");
        if (RndNumber == 1) FindObjectOfType<AudioManager>().Play("removedlife01");
        if (RndNumber == 2) FindObjectOfType<AudioManager>().Play("removedlife02");
        if (RndNumber == 3) FindObjectOfType<AudioManager>().Play("removedlife03");
        StartCoroutine(cameraShake.Shake(.5f, 0.02f,0.05f));
    }
}
 