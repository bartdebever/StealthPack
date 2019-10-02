using Assets.Script.Events;
using Assets.Script.MonoBehaviourExtensions;
using Assets.Script.Suspicious;
using UnityEngine.Events;

namespace Assets.Script.Basics
{
    public class BasicDetectionSystem : MonoDetectionSystem
    {
        private readonly UnityEvent<SuspiciousObject> _detectionEvent = new SuspiciousUnityEvent();

        /// <inheritdoc />
        public override void AddListener(UnityAction<SuspiciousObject> action)
        {
            _detectionEvent.AddListener(action);
        }
    }
}
