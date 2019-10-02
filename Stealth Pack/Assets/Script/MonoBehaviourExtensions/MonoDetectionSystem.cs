using Assets.Script.Interface;
using Assets.Script.Suspicious;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Script.MonoBehaviourExtensions
{
    public abstract class MonoDetectionSystem : MonoBehaviour, IDetectionSystem
    {
        /// <inheritdoc />
        public abstract void AddListener(UnityAction<SuspiciousObject> action);
    }
}
