using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// composant qui rend l'objet prenable par la manette
///
/// 
/// </summary>
public class PickableItem : MonoBehaviour
{
	
	bool isPickedUp;
	 
	public virtual void OnItemPickedUp(Transform holder) // holder = manette
	{
		isPickedUp = true;
		transform.SetParent(holder, true);
	}
	 
	public virtual void OnItemReleased() 
	{
		isPickedUp = false;
		transform.SetParent(null, true);
	}

}
