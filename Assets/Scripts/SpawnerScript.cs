using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnerScript : MonoBehaviour
{
    public GameObject[] drops;
    public float coolDown = 5f;
    private float timer = 0f;

    private Stack<GameObject> bundle = new Stack<GameObject>();

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= coolDown)
        {
            timer = 0f;

            if(bundle.Count == 0)
            {
                bundle = GetRandomStack(drops);
            }

            SpawnPrefab(bundle.Pop());
        }
    }
    
    //spawns random prefab from possible prefabs
    private void SpawnRandom()
    {
        int id = Random.Range(0, drops.Length);
        GameObject drop = Instantiate(drops[id], transform);
        Score.score++;
    }

    //spawns given prefab
    private void SpawnPrefab(GameObject go)
    {
        GameObject drop = Instantiate(go, transform);
        Score.score++;
    }

    //returns a randomized stack from the given array
    private Stack<GameObject> GetRandomStack(GameObject[] arr)
    {
        //randomize array
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int rnd = Random.Range(i, arr.Length);
            GameObject temp = arr[rnd];
            arr[rnd] = arr[i];
            arr[i] = temp;
        }

        //transform into stack and return
        return new Stack<GameObject>(arr);
    }

    
}
