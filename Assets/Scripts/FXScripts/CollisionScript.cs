using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public AudioSource collisionSound;
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
    shake = GameObject.FindGameObjectWithTag("shakeDeath").GetComponent<Shake>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision){

    //private void OnCollisionEnter(Collision collision){
        Debug.Log("Collision");
        collisionSound.Play();
        //effect.Play();
        shake.CamShakeHit();
        //effect.transform.position = this.transform.position; 
        //effect.Play();

        }
        
    
}
