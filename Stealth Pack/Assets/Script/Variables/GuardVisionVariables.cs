using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Script.Variables
{
    /// <summary>
    /// Variables to be used in combination with <see cref="MonoVisionForm"/>
    /// to allow finer control of the entity's vision from the Unity Editor.
    /// </summary>
    [Serializable]
    public struct GuardVisionVariables
    {
        /// <summary>
        /// The maximum radius that an entity is able to see.
        /// </summary>
        public float Radius { get; set; }

        /// <summary>
        /// The maximum amount of distance that an entity is able to see.
        /// </summary>
        public float MaxDistance { get; set; }
    }
}
