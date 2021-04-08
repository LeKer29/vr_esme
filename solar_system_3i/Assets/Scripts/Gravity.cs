using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public Rigidbody rb;
    private const float G = 667.4f;
    public static List<Gravity> Gravities;

    /// <summary>
    /// On applique la fonction Attract() sur toutes les planètes
    /// </summary>
    private void FixedUpdate()
    {
        foreach (Gravity gravity in Gravities)
        {
            if (gravity != this)
                Attract(gravity);
                
        }
    }

    /// <summary>
    /// On récupère l'ensemble des composants Gravity présents dans la simulation
    /// </summary>
    private void OnEnable()
    {
        if (Gravities == null)
            Gravities = new List<Gravity>();
        
        Gravities.Add(this);
    }

    private void OnDisable()
    {
        Gravities.Remove(this);
    }

    /// <summary>
    /// Cette fonction permet d'appliquer la force gravitationnelle universelle
    /// </summary>
    /// <param name="objToAttract"></param>
    void Attract(Gravity objToAttract)
    {
        Rigidbody rbToAttract = objToAttract.rb;

        Vector3 direction = rb.position - rbToAttract.position;
        float distance = direction.magnitude;

        if (distance == 0f)
            return;
        
        float forceMagnitude = G * (rb.mass * rbToAttract.mass) / Mathf.Pow(distance, 2);

        Vector3 force = direction.normalized * forceMagnitude;
        
        Vector3 orbit = Vector3.Cross(force, Vector3.up).normalized;
        
        rbToAttract.AddForce(force/2000,ForceMode.Acceleration);
        rbToAttract.velocity=orbit*6;
        
        

        
    }
}
