using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public GameObject DropContainer;

    public GameObject Spawner;

    private float standardHeight;

    private float SpawnerHeight;

    // Start is called before the first frame update
    void Start()
    {
        // minumum heights for both camera and spawner
        standardHeight = this.transform.position.y;
        SpawnerHeight = Spawner.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        int amount = GetChildren().Count -10 ; // how many drops?

        if (amount < 0) return; // less than 10? dont do anything

        float height = (float) (amount * 0.05); // we need more height

        Vector3 nextPosition = new Vector3(0, standardHeight + height, -10); // this will be next camera position
        Vector3 spawnerPosition = new Vector3(Spawner.transform.position.x, SpawnerHeight + height, 0); // next spawner position 

        float nextSize = (5 + height/2); // this will be next camera orthographic size

        this.transform.position = Vector3.Lerp(this.transform.position, nextPosition, Time.deltaTime * 1f); // lerp it!
        this.GetComponent<Camera>().orthographicSize = Mathf.Lerp(this.GetComponent<Camera>().orthographicSize, nextSize, 0.01f); // lerp it!!
        
        Spawner.transform.position = Vector3.Lerp(Spawner.transform.position, spawnerPosition, Time.deltaTime * 1f); // lerp it!
    }

    private List<GameObject> GetChildren()
    {
        List<GameObject> children = new List<GameObject>();
        foreach (Transform tran in DropContainer.transform)
        {
            {
                children.Add(tran.gameObject);
            }
        }
        return children;
    }
}
