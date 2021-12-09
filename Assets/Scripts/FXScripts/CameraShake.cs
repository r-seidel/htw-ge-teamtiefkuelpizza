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

        transform.localPosition = new Vector3(x, position.y+y, position.z);
    
    elapsed += Time.deltaTime;
    yield return null;
    
    }
    transform.localPosition = position;
}
}

