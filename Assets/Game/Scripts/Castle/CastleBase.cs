using System;
using Game.Scripts.Castle.SelectStates;
using Game.Scripts.Characters;
using Game.Scripts.UI;
using UnityEngine;

namespace Game.Scripts.Castle
{
    public abstract class CastleBase : MonoBehaviour
    {
        [SerializeField] protected CounterUI counterUI;
        
        [Header("Максимальное кол-во юнитов")] [SerializeField]
        protected uint maxCountUnits;

        protected StateOfCastle CurrentState = StateOfCastle.UnSelected;

        protected uint CurrentCountUnits;

        public event Action<CastleBase> OnMouseUpAboveCastle;
        
        public abstract void Init();

        public void AddUnits(uint count)
        {
            if (CurrentCountUnits + count > maxCountUnits)
                return;

            CurrentCountUnits += count;
            counterUI.SetValue(CurrentCountUnits);
        }

        public void SetState(StateOfCastle state) => CurrentState = state;

        private void OnMouseOver()
        {
            if (Input.GetMouseButtonUp(0))
                OnMouseUpAboveCastle?.Invoke(this);
        }
    }
}