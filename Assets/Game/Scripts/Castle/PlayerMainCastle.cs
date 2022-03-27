using Game.Scripts.Core;
using Game.Scripts.States;
using UnityEngine;

namespace Game.Scripts.Castle
{
    public class PlayerMainCastle : CastleBase
    {
        [Header("Параметры MainCastle")] [SerializeField]
        private StateBehaviour stateBehaviour;

        public override void Init()
        {
            CurrentCountUnits = PlayerCharacteristicController.StartCountUnits;
            counterUI.SetValue(CurrentCountUnits);
        }

        private void Start()
        {
            Init();

            stateBehaviour.SwitchState<ProduceState>();
        }
    }
}