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
    /// abstract class to be used to create different forms of vision an entity can have.
    /// The <see cref="OnTargetSpotted"/> event should be raised once an entity has been spotted.
    /// </summary>
    public abstract class MonoVisionForm : MonoBehaviour
    {
        /// <summary>
        /// Event to be raised when the target has been spotted.
        /// Value of this event will be the target that was spotted.
        /// </summary>
        public TargetSpottedUnityEvent OnTargetSpotted { get; set; }

        /// <summary>
        /// Overwritten method that is executed once.
        /// Used to initialize the <see cref="OnTargetSpotted"/>.
        /// </summary>
        protected virtual void Start()
        {
            OnTargetSpotted = new TargetSpottedUnityEvent();
        }
    }
}
