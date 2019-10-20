using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Script.Events
{
    /// <summary>
    /// Event to be used to indicate that a guard has spotted a target.
    /// </summary>
    public class TargetSpottedUnityEvent : UnityEvent<GameObject>
    {
    }
}
