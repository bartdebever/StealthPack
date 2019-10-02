using Assets.Script.Suspicious;
using UnityEngine.Events;

namespace Assets.Script.Events
{
    /// <summary>
    /// Event intended to be used for the detection system and when it sees suspicious objects.
    /// </summary>
    public class SuspiciousUnityEvent : UnityEvent<SuspiciousObject>
    {
    }
}
