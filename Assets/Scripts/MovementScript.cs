using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("RotateRight"))
        {
            GetComponent<SpawnerScript>().gameObject.transform.Rotate(0, 0, 90);
        }
        if (Input.GetButtonDown("RotateLeft"))
        {
            GetComponent<SpawnerScript>().gameObject.transform.Rotate(0, 0, -90);
        }

    }

    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            GetComponent<Rigidbody2D>().MovePosition(new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y));
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            GetComponent<Rigidbody2D>().MovePosition(new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y));
        }
        if (Input.GetAxis("Horizontal") == 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
}
