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
    /// Event to be used to alert a guard when a GameObject enters its zone.
    /// </summary>
    public class AlertZoneEnteredUnityEvent : UnityEvent<GameObject>
    {
    }
}
