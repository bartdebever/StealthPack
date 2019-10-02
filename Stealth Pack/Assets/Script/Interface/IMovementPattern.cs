using UnityEngine;

namespace Assets.Script.Interface
{
    /// <summary>
    /// Interface that should be implemented along side <see cref="MonoBehaviour"/>
    /// to be used to create a movement pattern for the guards.
    /// </summary>
    public interface IMovementPattern
    {
        /// <summary>
        /// Gets the current target for the guard in question.
        /// </summary>
        /// <returns>The target for the guard.</returns>
        Vector3 GetCurrentTarget();

        /// <summary>
        /// Gets the next target for the guard in question.
        /// </summary>
        /// <returns>The next target for the guard.</returns>
        Vector3 GetNextTarget();
    }
}

