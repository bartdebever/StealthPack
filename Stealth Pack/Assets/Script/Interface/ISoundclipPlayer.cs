using Assets.Script.Guards;

namespace Assets.Script.Interface
{
    /// <summary>
    /// Interface that should be used along side <see cref="MonoBehaviour"/>
    /// to play sounds corresponding to the state that the guard is in.
    /// </summary>
    public interface ISoundclipPlayer
    {
        /// <summary>
        /// Plays a sound based on the provided <paramref name="guardData"/>
        /// to indicate the situation to the player.
        /// </summary>
        /// <param name="guardData">
        /// The data about the guard that should make the noise.
        /// </param>
        void PlaySound(GuardData guardData);
    }
}
