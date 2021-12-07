using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionClampScript : MonoBehaviour
{
    public Vector3 highVector;
    public Vector3 lowVector;

    private void Update()
    {
        Vector3 pos = transform.position;

        transform.position = new Vector3(
            Mathf.Clamp(pos.x, lowVector.x, highVector.x),
            Mathf.Clamp(pos.y, lowVector.y, highVector.y),
            Mathf.Clamp(pos.z, lowVector.z, highVector.z));
    }
}
