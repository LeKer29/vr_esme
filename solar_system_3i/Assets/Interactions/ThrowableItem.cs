using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// composant qui permet de rendre l'objet lançable
/// hérite du comportement prenable
/// </summary>



public class ThrowableItem : PickableItem
{
    public override void OnItemPickedUp(Transform holder)
    {
        base.OnItemPickedUp(holder);
    }
}
