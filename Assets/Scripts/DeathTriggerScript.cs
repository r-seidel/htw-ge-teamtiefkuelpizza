using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTriggerScript : MonoBehaviour
{

    // added by Max
    //private FireScale fireScale;
    private Shake shake;
    private void Start(){
    shake = GameObject.FindGameObjectWithTag("shakeDeath").GetComponent<Shake>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        shake.CamShakeDeath();
        Destroy(collision.gameObject);
        Score.lifes--;
        Score.score--;
    }
}
 