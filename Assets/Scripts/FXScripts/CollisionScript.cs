using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public AudioSource collisionSound;
    public AudioSource collisionSound2;
    //public ParticleSystem effect;
    //public ShakeBig shakeBig;
    //public Animator camAnimator;
    public Shake shake;
    //public ParticelEffect particleSplash;
    //public FireCount firecount;
    //public Points Score;
    //public DecalSpalsh spash;

    // Start is called before the first frame update
    private void Start(){
    //collisionSound2 = GameObject.Find("Camera Shake").GetComponent<Shake>();
    shake = GameObject.FindGameObjectWithTag("shakeDeath").GetComponent<Shake>();
    collisionSound2 = GameObject.Find("objCol01").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision){

    //private void OnCollisionEnter(Collision collision){
        Debug.Log("Collision Prefabs on Pizza");
       // collisionSound.Play(); TODO
        //effect.Play();
        //shake.CamShakeHit(); TODO
        //effect.transform.position = this.transform.position; 
        //effect.Play();

        }
      void OnCollisionEnter2D(Collision2D col) {
          if (col.gameObject.tag == "ingredient") {
       //         collisionSound2.Play();
       //         shake.CamShakeSoft();

              Debug.Log("Collision Prefabs");
          }
      }

    /*void OnCollisionEnter2D(Collider2D col) {
        if (col.gameObject.tag == "zutat"){
            Debug.Log("Collision Spawner");
        }
    }
    */
    
}
