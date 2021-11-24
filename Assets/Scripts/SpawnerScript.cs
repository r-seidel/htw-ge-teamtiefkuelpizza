using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnerScript : MonoBehaviour
{
    public GameObject[] drops;
    GameObject drop;

    private float coolDown = 3;
    private float timer = 0;
    private bool preview = false;

    private Stack<GameObject> bundle = new Stack<GameObject>();
    private Stack<GameObject> nextBundle = new Stack<GameObject>();

    

    void Start()
    {
        bundle = GetRandomStack(drops);
        drop = bundle.Pop();
        SpawnPrefab(drop);
    }
   

    // Update is called once per frame
    void Update()
    {
        
        timer += Time.deltaTime;
        

        // Let loose the current previewed item
        if(timer >= 2.5 && preview)
        {
            drop.GetComponent<Rigidbody2D>().velocity = Vector3.zero; // no sideways speed
            Destroy(drop.GetComponent<FixedJoint2D>()); // drop it
            preview = false;
            Score.score++;
            drop = bundle.Pop();
        }

        if(timer >= coolDown)
        {
            timer = 0;
            
            if (bundle.Count == 0)
            {
                bundle = GetRandomStack(drops);
                
            }

            SpawnPrefab(drop);
        }
    }
    
    /*
    //spawns random prefab from possible prefabs
    private void SpawnRandom()
    {
        int id = Random.Range(0, drops.Length);
        GameObject drop = Instantiate(drops[id], transform);
        Score.score++;
    }
    */

    //spawns given prefab
    private void SpawnPrefab(GameObject go)
    {
        drop = Instantiate(go, transform);
        drop.AddComponent<FixedJoint2D>();
        drop.GetComponent<FixedJoint2D>().connectedBody = this.GetComponent<Rigidbody2D>();
        preview = true;
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

    public GameObject getDrop()
    {
        return drop;
    }
}
