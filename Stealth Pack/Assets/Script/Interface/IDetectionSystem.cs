using Assets.Script.Suspicious;
using UnityEngine.Events;

namespace Assets.Script.Interface
{
    /// <summary>
    /// A system that defines the detection of suspicious objects.
    /// </summary>
    public interface IDetectionSystem
    {
        /// <summary>
        /// Adds a listener to call when the system detects something suspicious.
        /// </summary>
        /// <param name="action">The action performed.</param>
        void AddListener(UnityAction<SuspiciousObject> action);
    }
}
