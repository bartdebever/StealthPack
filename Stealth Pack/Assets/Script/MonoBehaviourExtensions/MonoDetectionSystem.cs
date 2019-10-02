using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Script.Interface;
using UnityEngine;

namespace Assets.Script.MonoBehaviourExtensions
{
    public abstract class MonoDetectionSystem : MonoBehaviour, IDetectionSystem
    {
        public abstract void AddListener(Action action);
    }
}
