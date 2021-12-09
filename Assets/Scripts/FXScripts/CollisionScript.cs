using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{

    public ParticleSystem dropsEffectRed;
    public ParticleSystem dropsEffectWhite;
    public CameraShake cameraShake;
    public bool hasCollided = false;
    public bool playMusic = false;
    public int RndNumber;

   
    // Update is called once per frame
    void Update()
    {

    }
  
 
      void OnCollisionEnter2D(Collision2D col) {

        //Start Playing Music first Touch
        

        RndNumber = Random.Range(0,3);
          if (col.gameObject.tag == "ingredient" && hasCollided == false) {
            hasCollided = true;
              Instantiate(dropsEffectWhite,transform.position, Quaternion.identity);
             
              if (RndNumber == 0) FindObjectOfType<AudioManager>().Play("audioHitSoft");
              if (RndNumber == 1) FindObjectOfType<AudioManager>().Play("audioHitSoft");
                if (RndNumber == 2) FindObjectOfType<AudioManager>().Play("audioHitSoft2");
                if (RndNumber == 3) FindObjectOfType<AudioManager>().Play("audioHitSoft3");


                      Instantiate(dropsEffectRed,transform.position, Quaternion.identity);
                      StartCoroutine(cameraShake.Shake(.15f, 0.005f,0.02f));


            
              Debug.Log("Collision Prefabs");
          }
           if (col.gameObject.tag == "pizzaBase" && hasCollided == false) {
              
               hasCollided = true;
                Instantiate(dropsEffectRed,transform.position, Quaternion.identity);
                if (RndNumber == 0) FindObjectOfType<AudioManager>().Play("audioDropWet");
                if (RndNumber == 1) FindObjectOfType<AudioManager>().Play("audioDropWet");
                if (RndNumber == 2) FindObjectOfType<AudioManager>().Play("audioDropWet2");
                if (RndNumber == 3) FindObjectOfType<AudioManager>().Play("audioDropWet3");
                      
            
              Debug.Log("Collision PizzaBase");
          }
        StartCoroutine(cameraShake.Shake(.15f, 0.005f, 0.02f));
    }    
}
