using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementScript : MonoBehaviour
{
    public float speed = 1f;

    
    private Vector2 initialPosition;
    private Vector2 mousePosition;

    private float deltaX;

    private void Start()
    {
        initialPosition = transform.position;
    }

    void OnMouseDown()
    {
        
        deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
        
    }

    void OnMouseDrag()
    {
       
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePosition.x - deltaX,transform.position.y,transform.position.z);
        
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {

            GetComponent<SpawnerScript>().gameObject.transform.Rotate(0, 0, 90);
        }
        if (Input.GetKeyDown(KeyCode.S))
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
