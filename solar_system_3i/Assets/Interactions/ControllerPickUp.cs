using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// composant posé sur la manette de l'oculus
/// </summary>
///

/*
 * - quand on appuie sur un boutton détecter les objets à proximiter et leur envoyer un message
 * - quand on relache le bouton
*/

public class ControllerPickUp : MonoBehaviour
{

	Rigidbody pickedUpItem;
	
	public void PickUp() {
		Collider[] hitItems = Physics.OverlapSphere(transform.position, 0.3f);
		pickedUpItem = hitItems[0].attachedRigidbody;
		pickedUpItem.SendMessage("OnItemPickedUp", transform);
	}
	 
	public void Release() {
		pickedUpItem.SendMessage("OnItemReleased");
		pickedUpItem = null;
	}

}
