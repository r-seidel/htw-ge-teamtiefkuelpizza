using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTriggerScript : MonoBehaviour
{
    public GameObject missed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        shake.CamShakeDeath();
        intensityAnim.LightFireIntensity();
        //fireSound.Play();
        Debug.Log("Collision Deathtrigger");
        fireSound.Play();

        Destroy(collision.gameObject);
        missed.GetComponent<LifeScript>().RemoveLife();
        Score.score--;
    }
}
 