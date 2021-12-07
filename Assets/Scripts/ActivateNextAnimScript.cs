using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateNextAnimScript : MonoBehaviour
{
    public GameObject next;

    public void EnableNextObject()
    {
        next.SetActive(true);
    }
}
