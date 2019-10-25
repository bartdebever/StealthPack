using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Assets.Script.Exceptions;
using Assets.Script.MonoBehaviourExtensions;
using UnityEngine;

namespace Assets.Script.Basics
{
    public class BasicQuickSaver : MonoQuickSaver
    {
        private List<Dictionary<string, MonoQuickSaveableEntity>> _saves;

        public KeyCode KeyCode;

        public void Start()
        {
            _saves = new List<Dictionary<string, MonoQuickSaveableEntity>>();
        }

        public void Update()
        {
            if (Input.anyKeyDown && Input.GetKeyDown(KeyCode))
            {
                var entities = GetComponentsInChildren<MonoQuickSaveableEntity>();
                QuickSave(entities);
            }
        }

        /// <inheritdoc />
        public override int QuickSave(IEnumerable<MonoQuickSaveableEntity> entities)
        {
            var monoQuickSaveableEntities = entities.ToList();
            if (entities == null || !monoQuickSaveableEntities.Any())
            {
                throw new InvalidEntityCountException($"No items have been supplied for {nameof(entities)}.");
            }

            _saves.Add(
                monoQuickSaveableEntities.Select(entity => new {entity.UniqueId, entity})
                    .ToDictionary(entity => entity.UniqueId, entity => entity.entity));

            return _saves.Count - 1;
        }
    }
}
