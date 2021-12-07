using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithScript : MonoBehaviour
{
    public GameObject go;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = go.transform.position - this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = go.transform.position - offset;
    }
}
