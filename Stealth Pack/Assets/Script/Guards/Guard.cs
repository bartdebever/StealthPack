using Assets.Script.MonoBehaviourExtensions;
using UnityEngine;

namespace Assets.Script.Guards
{
    public class Guard : MonoBehaviour
    {
        #region Publics
        public GuardData GuardData;
        public MonoMovementHandler MovementHandler;
        public MonoMovementPattern MovementPattern;
        public MonoDetectionSystem DetectionSystem;
        #endregion

        #region Unity Methods
        protected virtual void FixedUpdate()
        {
            MovementHandler.Tick(gameObject);
        }
        #endregion

    }
}
