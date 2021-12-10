using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateNextAnimScript : MonoBehaviour
{
    public GameObject[] next;

    public void EnableNextObject()
    {
        foreach(GameObject go in next)
        {
            go.SetActive(true);
        }
    }
}
