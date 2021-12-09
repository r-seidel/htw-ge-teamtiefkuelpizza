using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{

    public ParticleSystem dropsEffectRed;
    public ParticleSystem dropsEffectWhite;

        //public ParticleSystem dropsOil;

    //public ShakeBig shakeBig;
    //public Animator camAnimator;
    public CameraShake cameraShake;
    public bool hasCollided = false;
        public bool playMusic = false;

    //public ParticelEffect particleSplash;
    //public FireCount firecount;
    //public Points Score;
    //public DecalSpalsh spash;

    public int RndNumber;

   


    // Start is called before the first frame update
    private void Start(){
    //collisionSound2 = GameObject.Find("Camera Shake").GetComponent<Shake>();
    //shake = GameObject.FindGameObjectWithTag("shakeDeath").GetComponent<Shake>();
    //collisionSound2 = GameObject.Find("objCol01").GetComponent<AudioSource>();
    }

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
              //StartCoroutine(cameraShake.Shake(.15f, 0.005f,0.02f));
              if (RndNumber == 0) FindObjectOfType<AudioManager>().Play("audioHitSoft");
              if (RndNumber == 1) FindObjectOfType<AudioManager>().Play("audioHitSoft");
                if (RndNumber == 2) FindObjectOfType<AudioManager>().Play("audioHitSoft2");
                if (RndNumber == 3) FindObjectOfType<AudioManager>().Play("audioHitSoft3");


                      Instantiate(dropsEffectRed,transform.position, Quaternion.identity);
                      StartCoroutine(cameraShake.Shake(.15f, 0.005f,0.02f));


            
              Debug.Log("Collision Prefabs");
          }
           if (col.gameObject.tag == "pizzaBase" && hasCollided == false) {
               //StartCoroutine(cameraShake.Shake(.15f, 0.05f,0.1f));
               hasCollided = true;
                Instantiate(dropsEffectRed,transform.position, Quaternion.identity);
                //StartCoroutine(cameraShake.Shake(.15f, 0.01f,0.1f));
                if (RndNumber == 0) FindObjectOfType<AudioManager>().Play("audioDropWet");
                if (RndNumber == 1) FindObjectOfType<AudioManager>().Play("audioDropWet");
                if (RndNumber == 2) FindObjectOfType<AudioManager>().Play("audioDropWet2");
                if (RndNumber == 3) FindObjectOfType<AudioManager>().Play("audioDropWet3");
                      
            
              Debug.Log("Collision PizzaBase");
          }
      }    
}
