using System;
using DG.Tweening;
using UnityEngine;

namespace Game.Scripts.Characters
{
    public class Character : MonoBehaviour
    {
        [Header("Скорость персонажа")]
        [SerializeField] private float moveSpeed = 2f;
        
        private Tween _moveTween;

        private Action _moveCallback;

        public void OnMoveComplete(Action callback) => _moveCallback += callback;

        public void MoveTo(Vector2 target)
        {
            _moveTween.Kill();
            _moveTween = transform.DOMove(target, moveSpeed)
                .SetEase(Ease.Linear)
                .SetSpeedBased(true)
                .OnComplete(MoveComplete)
                .SetAutoKill(false);
        }

        private void MoveComplete()
        {
            _moveCallback?.Invoke();
            _moveCallback = null;
        }
    }
}
