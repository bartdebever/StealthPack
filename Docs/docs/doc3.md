---
id: doc3
title: Quick saving
---

```cs
public class UnityComponent : MonoBehaviour, ISaveableScript
{
    private void Start()
    {
        UniqueId = GUID.Generate();
        SaveStateStorage.Get.Add(UniqueId, this);
    }

    public GUID UniqueId { get; private set; }

    private void Load(Dictionary<string, object> saveState)
    {
        // Implement loading
    }

    private Dictionary<string, object> Save()
    {
        // Implement saving.
    }
}
```
