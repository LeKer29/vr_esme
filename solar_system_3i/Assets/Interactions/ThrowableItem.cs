using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// composant qui permet de rendre l'objet lançable
/// hérite du comportement prenable
/// </summary>



public class ThrowableItem : PickableItem
{
    private Vector3 lastPosition;
    private Vector3 currentPosition;
    private Vector3 speed;
    public Rigidbody rb;
    
    public override void OnItemReleased()
    {
        if (currentPosition != lastPosition)
        {
            speed = (lastPosition - currentPosition) / Time.deltaTime;
            rb.velocity = speed;
        }
        
        base.OnItemReleased();
    }

    public override void Update()
    {
        if(currentPosition != null)
            lastPosition = currentPosition;
        
        currentPosition = transform.position;   
        
        base.Update();
        
    }
    
}
