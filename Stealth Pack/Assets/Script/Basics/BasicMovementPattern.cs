using System.Collections.Generic;
using Assets.Script.MonoBehaviourExtensions;
using UnityEngine;

namespace Assets.Script.Basics
{
    /// <summary>
    /// Provides a very basic movement pattern easily implemented by provided
    /// <see cref="Vector3"/> objects as a position.
    /// </summary>
    public class BasicMovementPattern : MonoMovementPattern
    {
        /// <summary>
        /// The points that the guard will move to.
        /// </summary>
        public List<Vector3> Pattern;

        /// <summary>
        /// Defines if the Gizmos should draw where the guard is looking at.
        /// </summary>
        public bool DrawGizmos;

        /// <summary>
        /// The current state in which the guard is within the array.
        /// </summary>
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
