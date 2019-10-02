using System;
using UnityEngine;

namespace Assets.Script.Guards
{
    /// <summary>
    /// The data and characteristics for the guard object.
    /// </summary>
    [Serializable]
    public class GuardData : MonoBehaviour
    {
        /// <summary>
        /// The alert level that the guard currently has.
        /// </summary>
        public float AlertLevel;

        /// <summary>
        /// The maximum number that the alert level can go to.
        /// </summary>
        public float MaxAlertLevel;

        /// <summary>
        /// The movement speed that the guard has.
        /// </summary>
        public float MovementSpeed;
    }
}

