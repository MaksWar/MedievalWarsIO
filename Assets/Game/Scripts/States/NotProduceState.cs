using Game.Scripts.Castle;
using UnityEngine;

namespace Game.Scripts.States
{
    public class NotProduceState : StateBase
    {
        public NotProduceState(CastleBase castleBase, IStateSwitcher stateSwitcher) : base(castleBase, stateSwitcher)
        {
            
        }

        public override void StartState()
        {
            base.StartState();

            Logic();
        }

        public override void Logic()
        {
            Debug.Log("Not Produce");
        }
        
        
    }
}