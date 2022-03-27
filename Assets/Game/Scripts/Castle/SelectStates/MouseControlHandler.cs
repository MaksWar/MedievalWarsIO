using System;
using UnityEngine;

namespace Game.Scripts.Castle.SelectStates
{
    public class MouseControlHandler : MonoBehaviour
    {
        [Header("Камера")] [SerializeField] private Camera camera;

        public event Action OnMouseButtonUp;
        public event Action<RaycastHit2D> OnHitCollider;
        
        private void Update()
        {
            if (Input.GetMouseButton(0))
            {
                Vector2 worldPosition = camera.ScreenToWorldPoint(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(worldPosition, Vector2.zero);
                
                if (hit.collider != null) 
                    OnHitCollider?.Invoke(hit);
            }
            else if (Input.GetMouseButtonUp(0))
            {
                OnMouseButtonUp?.Invoke();
            }
        }

        #region Editor

        private void OnValidate()
        {
            if (camera == null)
                camera = Camera.main;
        }

        #endregion
    }
}