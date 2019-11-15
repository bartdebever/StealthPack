---
id: quicksaving
title: Quick saving
---

Quick saving and quick loading are important parts of a stealth based game.
The player wants to be back in the action as soon as possible and not go into
a menu to save their changes.

Within this asset pack, quick saving is fully implemented and customizable.

## Quick saving entities

To provide the option to quicksave a game, there is the `ISaveableScript` interface.
This interface defines the `Save()` and `Load()` methods.
These methods will be called by the other systems when the user or your own code.
Calls for a save or load action on the manager class.

There is also a definition for a `GUID`. This value is used as the key to store and
retrieve the values that the entity had. This value has to be unique else an
`System.ArgumentException` will be thrown.

The following code example will showcase a basic implementation of the `ISaveableScript`
interface.

```cs
public class UnityComponent : MonoBehaviour, ISaveableScript
{
    private void Start()
    {
        UniqueId = GUID.Generate();
        QuickSaveStorage.Get.Add(UniqueId, this);
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

## QuickSaveStorage

The storage for the quick load- and saveable scripts is done using a singleton.
The `QuickLoadStorage` keeps a list of `ISaveableScript`s and calls the methods
on these where needed.
An instance of this storage can be gotten when using the `Get` property.

To add an `ISaveableScript` to the storage, use the `AddScript` method.
This method's only parameter is the `ISavebleScript`. (Please see the example
above on how to add a script.)

Exceptions:

- `ArgumentNullException`: when the provided `ISaveableScript` is null.
- `ArgumentException`: when the `ISaveableScript.UniqueId` was already in the list.

When calling `Save()` or `Load()`, a loop will start that goes over all provided
`ISaveableScript`s and call the `Save()` or `Load()` method on that script.
If an exception happens during that time, it will be catched and logged.

When calling `Load()` without a state being saved before, the code will not execute
and just return instead.

## Saving and loading states

To make the user be able to quick load and save, the `Quicksaver` class has been made.
This calls the respective methods on the `QuickSaveStorage` when the player
presses the key set as the `saveKey` or `loadKey`.

When using custom forms of input like Rewired, please implement your own version
of this `Quicksaver`. Underneath is the implementation of this script.
If you do make a version based on your custom input method, please feel free to
send in a pull request on the
[GitHub project](https://github.com/bartdebever/StealthPack).

```cs
/// <summary>
/// Simple MonoBehaviour that allows for entities to be quick saved and
/// loaded.
/// </summary>
public class Quicksaver : MonoBehaviour
{
    /// <summary>
    /// The key used to save the current entities.
    /// </summary>
    public KeyCode saveKey;

    /// <summary>
    /// The key used to load the current entities.
    /// </summary>
    public KeyCode loadKey;

    private void Update()
    {
        if (Input.anyKeyDown && Input.GetKeyDown(saveKey))
        {
            QuickSaveStorage.Get.Save();
        }

        if (Input.anyKeyDown && Input.GetKeyDown(loadKey))
        {
            QuickSaveStorage.Get.Load();
        }
    }
}
```

## Saving and loading inherited scripts

When inheriting from classes like `BasicStateMachine`, these classes will have
already implemented the `ISaveableEntity` interface themselves.
These implementations are virtual and can be overwritten.

### UniqueId

To set the unique ID to a unique value of some sorts, override the `Start()` method.

```cs
protected override void Start()
{
    base.Start();
    UniqueId = GUID.Generate();
    QuickSaveStorage.Get.AddScript(this);
}
```

With `base.Start()` the method on the base class will called, this might be important
if the method has other logic in it.

### Save & Load

The following is an example of the `CustomGuard` class in the test project.

```cs
public override Dictionary<string, object> Save()
{
    // Get the dictionary from the base class and expand on it.
    var saveState = base.Save();
    saveState.Add("position", gameObject.transform.position);
    saveState.Add("target", _target);
    saveState.Add("state", _state);
    return saveState;
}
public override void Load(Dictionary<string, object> saveState)
{
    // Let the base class handle the loading for it's variables.
    base.Load(saveState);
    gameObject.transform.position = (Vector3) saveState["position"];
    _target = (Vector3?) saveState["target"];
    _state = (GuardModes) saveState["state"];
    ToggleSearching();
}
```
