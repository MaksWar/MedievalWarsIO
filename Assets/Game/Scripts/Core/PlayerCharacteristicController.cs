using System;

namespace Game.Scripts.Core
{
    [Serializable]
    public static class PlayerCharacteristicController
    {
        private static float _unitPerSecond = 1;
        private static uint _startCountUnits = 25;

        private const float CoefficientToUpgrade = 0.13f;
        private const uint StartCountUnitToUpgrade = 1;
        
        public static float UnitPerSecond => _unitPerSecond;
        public static float TimeToProduceOneUnit => 1 / _unitPerSecond;
        public static uint StartCountUnits => _startCountUnits;
        
        public static void UpgradeUnitPerSecond() => _unitPerSecond += CoefficientToUpgrade;
        public static void UpgradeStartCountUnits() => _startCountUnits += StartCountUnitToUpgrade;
    }
}