using Assets.Script.Guards;
using Assets.Script.Interface;
using UnityEngine;

namespace Assets.Script.MonoBehaviourExtensions
{
    /// <summary>
    /// Basic abstract class that implements <see cref="MonoBehaviour"/> and
    /// <see cref="IMovementHandler"/>.
    /// </summary>
    public abstract class MonoMovementHandler : MonoBehaviour, IMovementHandler
    {
        /// <summary>
        /// The movement pattern to get the targets from.
        /// </summary>
        public MonoMovementPattern MovementPattern;

        /// <inheritdoc />
        public abstract void SetTarget(Vector3 target, GuardData guardData);

        /// <inheritdoc />
        public abstract void Tick(GameObject gameObject);
    }
}
