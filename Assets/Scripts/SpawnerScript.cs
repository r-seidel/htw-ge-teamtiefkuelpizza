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
    public GameObject dropContainer;

    

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
        

        // drop the current previewed item
        if(timer >= 2.5 && preview)
        {
            drop.GetComponent<Rigidbody2D>().velocity = Vector3.zero; // no sideways speed
            Destroy(drop.GetComponent<FixedJoint2D>()); // drop it
            drop.transform.parent = dropContainer.transform;
            preview = false;
            Score.score++;
            drop = bundle.Pop();
        }

        // reset timer and spawn new item
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

    //spawns given prefab
    private void SpawnPrefab(GameObject go)
    {
        drop = Instantiate(go, transform);
        addJoint(drop);
        preview = true;
    }

    // adding Joint(s)
    private void addJoint(GameObject drop)
    {
        drop.AddComponent<FixedJoint2D>(); // create joint
        drop.GetComponent<FixedJoint2D>().connectedBody = this.GetComponent<Rigidbody2D>(); // attach joint

        if (drop.transform.childCount == 0) return; // if not mozarella -> return | else create more joints, so the mozarella doesnt glitch

        for(int i = 0; i<=drop.transform.childCount; i++) // for each child
        {
            GameObject child = drop.transform.GetChild(i).gameObject;
            if (child.name.Equals("Skin")) break; // check if point or skin
            child.AddComponent<FixedJoint2D>(); // create joint
            child.GetComponent<FixedJoint2D>().connectedBody = this.GetComponent<Rigidbody2D>(); // attach joint
        }
    }

    // removing Joint(s)
    private void removeJoint(GameObject drop) 
    {
        Destroy(drop.GetComponent<FixedJoint2D>()); // destroy / let it fall

        if (drop.transform.childCount == 0) return; // if not mozarella -> return

        for (int i = 0; i <= drop.transform.childCount; i++) // for each child
        {
            GameObject child = drop.transform.GetChild(i).gameObject;

            if (child.name.Equals("Skin")) break; // check if point or skin

            Destroy(child.GetComponent<FixedJoint2D>()); // destroy / let it fall
        }
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
