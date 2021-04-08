using UnityEngine;

namespace Interactions
{
    /// <summary>
    /// composant qui permet de rendre l'objet lançable
    /// hérite du comportement prenable
    /// </summary>
    public class ThrowableItem : PickableItem
    {
        private Vector3 _lastPosition;
        private Vector3 _currentPosition;
        private Vector3 _speed;
        public Rigidbody rb;
    
        
        /// <summary>
        /// Quand l'objet est relaché, on lui applique une vitesse proportionnelle à la distance parcourue entre 2 frames.
        /// </summary>
        public override void OnItemReleased()
        {
            if (_currentPosition != _lastPosition)
            {
                _speed = (_lastPosition - _currentPosition) / Time.deltaTime;
                rb.velocity = _speed;
            }
        
            base.OnItemReleased();
        }
        

        public override void Update()
        {
            if(_currentPosition != null)
                _lastPosition = _currentPosition;
        
            _currentPosition = transform.position;   
        
            base.Update();
        }
    
    }
}
