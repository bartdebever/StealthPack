using System.Collections.Generic;
using UnityEngine;
using Assets.Script.Exceptions;

namespace Assets.Script.MonoBehaviourExtensions
{
    public abstract class MonoQuickSaver : MonoBehaviour
    {
        /// <summary>
        /// Quicksaves the <paramref name="entities"/> provided making them
        /// available to be quickloaded.
        /// </summary>
        /// <param name="entities">The entities to be saved.</param>
        /// <returns>The slot in which the entities are saved.</returns>
        /// <exception cref="InvalidEntityCountException">
        /// Thrown when <paramref name="entities"/> is null or empty.
        /// </exception>
        public abstract int QuickSave(IEnumerable<MonoQuickSaveableEntity> entities);
    }
}
