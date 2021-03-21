using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public Rigidbody sunRB;
    public float gravity;
    public Rigidbody planetRB;
    
    
    void Update()
    {
       ApplyGravity(); 
    }

    void ApplyGravity()
    {
        Vector3 difference =  sunRB.position- this.gameObject.transform.position;
        float dist = difference.magnitude;
        Vector3 gravityDirection = difference.normalized;
        Vector3 gravityVector = (gravityDirection * gravity) / (dist * dist) ;
        planetRB.AddForce(gravityVector, ForceMode.VelocityChange);
    }
    
}
