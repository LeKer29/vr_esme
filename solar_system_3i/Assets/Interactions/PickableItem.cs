using UnityEngine;

namespace Interactions
{
	/// <summary>
	/// composant qui rend l'objet prenable par la manette
	/// </summary>
	public class PickableItem : MonoBehaviour
	{
		public bool isPickedUp;
		public Gravity objGravity;
	 
		/// <summary>
		/// Cette fonction rend un objet prenable
		/// </summary>
		/// <param name="holder">Correspond au transform de l'objet simulant la manette</param>
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


		public virtual void Update()
		{
			if (isPickedUp)
			{
				// On désactive la gravité d'un objet attrapé
				objGravity.enabled = false;
				transform.position = transform.parent.position;
			}
			else
			{
				objGravity.enabled = true;
			}
		}
	}
}
