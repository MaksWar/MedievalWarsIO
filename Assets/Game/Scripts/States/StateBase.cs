using Game.Scripts.Castle;
using UnityEngine;

namespace Game.Scripts.States
{
    public abstract class StateBase
    {
        protected readonly CastleBase CastleBase;
        protected readonly IStateSwitcher StateSwitcher;

        protected StateBase(CastleBase castleBase, IStateSwitcher stateSwitcher)
        {
            CastleBase = castleBase;
            StateSwitcher = stateSwitcher;
        }

        /// <summary>
        /// Активное ли данное состояние
        /// </summary>
        protected bool IsActive = false;

        /// <summary>
        /// Стартовая точка состояния
        /// </summary>
        public virtual void StartState()
        {
            IsActive = true;
        }

        /// <summary>
        /// Метод с логикой состояния
        /// </summary>
        public abstract void Logic();

        /// <summary>
        /// Точка выхода из состояния
        /// </summary>
        public virtual void StopState()
        {
            IsActive = false;
        }
    }
}