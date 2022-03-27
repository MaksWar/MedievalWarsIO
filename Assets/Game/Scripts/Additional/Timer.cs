using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Scripts.Additional
{
    public class Timer : MonoBehaviour
    {
        public event Action OnTimeEnd;

        public void StartTimer(float time) => StartCoroutine(ProcessTimer(time));

        public void StopTimer() => StopAllCoroutines();
        
        private IEnumerator ProcessTimer(float time)
        {
            while (true)
            {
                yield return new WaitForSeconds(time);

                OnTimeEnd?.Invoke();
            }
        }
    }
}