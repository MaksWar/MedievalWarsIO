using System.Collections.Generic;
using System.Linq;
using Game.Scripts.Additional;
using Game.Scripts.Castle;
using UnityEditor;
using UnityEngine;

namespace Game.Scripts.States
{
    public class StateBehaviour : MonoBehaviour, IStateSwitcher
    {
        [SerializeField] private CastleBase castle;
        [SerializeField] private Timer timer;
        
        private StateBase _currentState;
        private List<StateBase> _allStates;

        private void Awake()
        {
            _allStates = new List<StateBase>()
            {
                new ProduceState(castle, this, timer),
                new NotProduceState(castle, this),
            };
            _currentState = _allStates[0];
        }

        public void SwitchState<T>() where T : StateBase
        {
            var state = _allStates.FirstOrDefault(s => s is T);
            
            _currentState.StopState();
            state.StartState();
            
            _currentState = state;
        }
    }

    [CustomEditor(typeof(StateBehaviour))]
    public class StateBehaviourEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            StateBehaviour stateBehaviour = (StateBehaviour) target;
            if(GUILayout.Button("Set Produce State"))
                stateBehaviour.SwitchState<ProduceState>();
            if(GUILayout.Button("Set NotProduce State"))
                stateBehaviour.SwitchState<NotProduceState>();
            
        }
    }
}