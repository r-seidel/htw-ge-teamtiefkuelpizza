using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{

public Animator camAnimator;

public void CamShakeDeath(){
    camAnimator.SetTrigger("shakeBig");
}
public void CamShakeHit(){
    int random = Random.Range(0,3);
    if (random == 0) { 
        camAnimator.SetTrigger("shakeSmall00");
        Debug.Log("CollisionSmall00");
    } else if (random == 1) {
        camAnimator.SetTrigger("shakeSmall01");
        Debug.Log("CollisionSmall01");
    } else if (random == 2) {
        camAnimator.SetTrigger("shakeSmall02");
        Debug.Log("CollisionSmall02");
    }
}

/*public void CamShakeBig(){
    camAnimator.SetTrigger("camShakeBig");
}
*/


}
