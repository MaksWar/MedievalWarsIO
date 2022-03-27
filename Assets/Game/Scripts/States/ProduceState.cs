using Game.Scripts.Additional;
using Game.Scripts.Castle;
using Game.Scripts.Core;
using UnityEngine;

namespace Game.Scripts.States
{
    public class ProduceState : StateBase
    {
        private Timer _timer;
        
        public ProduceState(CastleBase castleBase, IStateSwitcher stateSwitcher, Timer timer) : base(castleBase, stateSwitcher)
        {
            _timer = timer;

            _timer.OnTimeEnd += AddUnitsAfterTimerEnd;
        }

        public override void StartState()
        {
            base.StartState();
            
            Logic();
        }

        public override void Logic() => _timer.StartTimer(PlayerCharacteristicController.TimeToProduceOneUnit);

        public override void StopState()
        {
            base.StopState();
            
            _timer.StopTimer();
        }

        private void AddUnitsAfterTimerEnd() => CastleBase.AddUnits(1);
    }
}