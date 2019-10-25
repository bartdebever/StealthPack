using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Script.MonoBehaviourExtensions
{
    public class MonoQuickSaveableEntity
    {
        public string UniquePrefix = "Entity";
        public string UniqueId { get; private set; }

        protected void Start()
        {
            UniqueId = $"{UniquePrefix}-{Guid.NewGuid()}";
        }
    }
}
