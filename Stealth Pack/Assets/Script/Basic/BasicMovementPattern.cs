using System.Collections.Generic;
using Assets.Script.Interface;
using Assets.Script.MonoBehaviourExtensions;
using UnityEngine;

namespace Assets.Script.Basic
{
    /// <summary>
    /// Provides a very basic movement pattern easily implemented by provided
    /// <see cref="Vector3"/> objects as a position.
    /// </summary>
    public class BasicMovementPattern : MonoMovementPattern
    {
        public List<Vector3> Pattern;
        public bool DrawGizmos;

        private int _currentState;

        /// <inheritdoc />
        public override Vector3 GetCurrentTarget()
        {
            return Pattern[_currentState];
        }

        /// <inheritdoc />
        public override Vector3 GetNextTarget()
        {
            if (++_currentState >= Pattern.Count)
            {
                _currentState = 0;
            }

            return Pattern[_currentState];
        }
    }
}
