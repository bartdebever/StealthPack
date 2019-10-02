using Assets.Script.Guards;
using UnityEngine;

namespace Assets.Script.Interface
{
    /// <summary>
    /// Interface to be implemented along side of <see cref="MonoBehaviour"/>
    /// to move the <see cref="GameObject"/> attached to this script.
    /// </summary>
    public interface IMovementHandler
    {
        /// <summary>
        /// Sets the target that the attached <see cref="GameObject"/> should move to.
        /// </summary>
        /// <param name="target">The target point in the world.</param>
        /// <param name="guardData">The data from the guard being moved.</param>
        void SetTarget(Vector3 target, GuardData guardData);

        /// <summary>
        /// Progresses the <paramref name="gameObject"/> to it's target.
        /// </summary>
        /// <param name="gameObject">The object to be moved.</param>
        void Tick(GameObject gameObject);
    }
}
