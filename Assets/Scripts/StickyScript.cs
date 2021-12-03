using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.GetComponent<DistanceJoint2D>() == null) // prevent mozarella from connecting to itself
        {
            // creates joint
            FixedJoint2D joint = gameObject.AddComponent<FixedJoint2D>();
            // sets joint position to point of contact
            joint.anchor = col.contacts[0].point;
            // conects the joint to the other object
            joint.connectedBody = col.gameObject.GetComponent<Rigidbody2D>();
                
            // Stops objects from continuing to collide and creating more joints
            joint.enableCollision = false;
        }
    }
}
