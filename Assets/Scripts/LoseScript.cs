using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseScript : MonoBehaviour
{
    public GameObject spawner;

    // Start is called before the first frame update
    void Start()
    {
        spawner.GetComponent<MovementScript>().enabled = false;
        spawner.GetComponent<SpawnerScript>().enabled = false;

        Time.timeScale = 0f;
    }
}
