using System.Collections.Generic;
using Game.Scripts.Castle.SelectStates;
using UnityEngine;

namespace Game.Scripts.Castle
{
    public class CastleMediator : MonoBehaviour
    {
        [SerializeField] private MouseControlHandler mouseSelectionHandler;
        [SerializeField] private List<CastleBase> castles;

        private void Start()
        {
            mouseSelectionHandler.OnMouseButtonUp += UnSelectCastles;
            mouseSelectionHandler.OnHitCollider += CheckSelectedCastles;
        }

        private void UnSelectCastles() => castles.ForEach(castle => castle.SetState(StateOfCastle.UnSelected));
        private void CheckSelectedCastles(RaycastHit2D hit)
        {
            foreach (CastleBase castle in castles)
            {
                if (hit.collider.gameObject == castle.gameObject)
                    castle.SetState(StateOfCastle.Selected);
            }
        }
    }
}