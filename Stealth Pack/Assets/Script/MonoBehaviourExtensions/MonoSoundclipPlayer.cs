using Assets.Script.Guards;
using Assets.Script.Interface;
using UnityEngine;

namespace Assets.Script.MonoBehaviourExtensions
{
    /// <summary>
    /// Basic abstract class that implements <see cref="MonoBehaviour"/> and
    /// <see cref="ISoundclipPlayer"/>.
    /// </summary>
    public abstract class MonoSoundclipPlayer : MonoBehaviour, ISoundclipPlayer
    {
        /// <inheritdoc />
        public abstract void PlaySound(GuardData guardData);
    }
}
