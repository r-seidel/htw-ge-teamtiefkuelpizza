using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{


public IEnumerator Shake(float time, float powerX,float powerY){
    Vector3 position = transform.localPosition;
    float elapsed = 0.0f;
    while (elapsed < time){
        float x = Random.Range(-1f, 1f) * powerX;

        float y = Random.Range(-1f, 1f) * powerY;

        transform.localPosition = new Vector3(x,y, position.z);
    
    elapsed += Time.deltaTime;
    yield return null;
    
    }
    transform.localPosition = position;
}
}




/*
jkjlk
*/
/*
//old Script ANimator Method:
public void CamShakeDeath(){
    camAnimator.SetTrigger("shakeBig");
    Debug.Log("CAM Shake DEATH");
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
public void CamShakeSoft(){
    int random = Random.Range(0,3);
    if (random == 0) { 
        camAnimator.SetTrigger("shakeSoft00");
        Debug.Log("Soft");
    } else if (random == 1) {
        camAnimator.SetTrigger("shakeSmall01");
        Debug.Log("Shake Hard1");
    } else if (random == 2) {
        camAnimator.SetTrigger("shakeSmall02");
        Debug.Log("Shake Hard2");
    }
}

*/

