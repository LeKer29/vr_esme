using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    private Sun sun;
    
    void Start()
    {
        sun = Sun.Instance;         
    }


    private void FixedUpdate()
    {
        // transform.GetComponent<Rigidbody>().AddForce(transform.forward, ForceMode.Acceleration);    
        //transform.GetComponent<Rigidbody>().AddForce(gravityVector, ForceMode.Acceleration);    

    }
}
