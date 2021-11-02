using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject[] drops;
    public float range = 3f;
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

    public void SpawnRandom()
    {
        int id = Random.Range(0, drops.Length);
        Spawn(drops[id]);
    }

    public void Spawn(GameObject go)
    {
        GameObject drop = Instantiate(go, transform);
        float rnd = Random.Range(-range, range);
        drop.transform.position = new Vector2(drop.transform.position.x + rnd, drop.transform.position.y);
        
    }
}
