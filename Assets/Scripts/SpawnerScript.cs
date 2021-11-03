using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnerScript : MonoBehaviour
{
    public GameObject[] drops;
    public float coolDown = 5f;
    private float timer = 0f;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= coolDown)
        {
            timer = 0f;
            SpawnRandom();
        }
    }
 
    private void SpawnRandom()
    {
        int id = Random.Range(0, drops.Length);
        GameObject drop = Instantiate(drops[id], transform);
        Score.score++;
    }

    
}
