using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Scripts.UI
{
    public class CounterUI : MonoBehaviour
    {
        [SerializeField] private Text counter;

        public void SetValue(uint value) => counter.text = value.ToString();
    }
}