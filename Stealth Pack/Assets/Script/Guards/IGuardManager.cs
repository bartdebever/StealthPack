using UnityEngine;

namespace Assets.Script.Guards
{
    public interface IGuardManager
    {
        /// <summary>
        /// Changes the global state of this manager when an enemy has been spotted.
        /// </summary>
        /// <param name="gameObject">The enemy spotted</param>
        /// <param name="guard">The guard that spotted the enemy.</param>
        void EnemySpotted(GameObject gameObject, Guard guard);

        /// <summary>
        /// Changes the global alert level after having found an object.
        /// </summary>
        /// <param name="alert">The amount that the alert level should change by.</param>
        /// <param name="guard">The guard responsible for the change.</param>
        void ChangeAlertLevel(float alert, Guard guard);
    }
}


