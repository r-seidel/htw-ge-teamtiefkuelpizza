using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParent : MonoBehaviour
{
    void OnDestroy()
    {
        Destroy(this.transform.parent.gameObject);
    }
}
