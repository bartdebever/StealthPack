using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Script.Events;
using UnityEngine;

namespace Assets.Script.MonoBehaviourExtensions
{
    /// <summary>
    /// <see cref="MonoBehaviour"/> extensions that implements the maximum
    /// amount of distance that <see cref="GameObject"/>s are allowed to get to another <see cref="GameObject"/>.
    /// When this radius is entered, the <see cref="OnEnterAlert"/> event
    /// with the <see cref="GameObject"/> as the value being passed.
    /// </summary>
    public class MonoAlertDistance : MonoBehaviour
    {
        /// <summary>
        /// The radius that the entity will check around itself.
        /// </summary>
        public float Radius;

        /// <summary>
        /// The alert triggered when a <see cref="GameObject"/> is to close
        /// to the <see cref="GameObject"/> this script is placed on.
        /// </summary>
        public AlertZoneEnteredUnityEvent OnEnterAlert;

        /// <summary>
        /// Start method that is executed once when creating the script and the
        /// <see cref="GameObject"/>.
        /// Used to initialize the <see cref="OnEnterAlert"/>.
        /// </summary>
        protected virtual void Start()
        {
            OnEnterAlert = new AlertZoneEnteredUnityEvent();
        }
    }
}
