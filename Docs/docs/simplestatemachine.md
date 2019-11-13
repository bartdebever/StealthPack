---
id: guard
title: Guard (SimpleStateMachine)
---

The guard script is the main script that puts all the smaller pieces together.
It is the hub where the main logic of the guard's AI will be made and where most
of the work will go into.

# SimpleStateMachine

The `SimpleStateMachine` is the class that the `Guard` class inherits from.
This script has a float variable called `alert`. When an object is spotted, the
alert level a guard has goes up, once they are done investigating this object,
the alert can go down again.

As a developer, it is possible to specify the actions that should be taken at what
alert level. These actions **only** get executed when the alert level changes.

The action will be picked from the `StateActions` dictionary, more the dictionary later.
To determine what action should be performed a simple search is executed.

## Executing actions

At first the alert is increased with the change amount, it does not check for negative
values and will decrease the alert level when a negative amount is supplied.

If the new amount is lower than 0, it will be reset back to 0. If the new amount
is higher than the maximum amount, it will be set to the maximum amount.

After this is done, the search for an action to perform begins.
The `StateActions` dictionary is taken and looped through backwards.
If the alert level is higher than the one required for the action, the action is executed.

### Example

Actions defined:

- 20, ActionX
- 10, ActionY
- 0, ActionZ

Alert level and actions that will be performed:

- 20 -> ActionX
- 19 -> ActionY
- 19.9 -> ActionY
- 9 -> ActionZ
- 0 -> ActionZ

## Defining actions

Actions can be defined that should be executed for the minimum amount of alert.
These actions can be methods, lambdas or anything else that C# allows for.

One parameter will be passed which is the spotted object. This is the object
that caused the alert to go too high.

### Example

This example is taken from the test game. These specific implementations should
not be copied, it is more to give an impression of what can be done.

```cs
public override Dictionary<float, Action<GameObject>> StateActions => new Dictionary<float,Action<GameObject>>()
{
    {0, (spottedObject) =>
    {
        ToggleSearching();
        _overrideTarget = null;
        _state = GuardModes.Route;
    }},
    {20, (spottedObject) =>
    {
        // If the dictionary already contains the object found, update it's position in the list.
        if (_spottedObjects.ContainsKey(spottedObject))
        {
            // Update the objects position with a new position.
            _spottedObjects[spottedObject] = spottedObject.transform.position;
        }
        else
        {
            // Add the object to the dictionary.
            _spottedObjects.Add(spottedObject, spottedObject.transform.position);
        }
        var guardManager = GetComponentInParent<GuardManager>();
        guardManager.AlertObject(spottedObject);
        _overrideTarget = spottedObject;
        _state = GuardModes.Searching;
        ToggleSearching();
    }}
};
```

## Changing the state and not calling actions

There is also an option to change the state of the guard without calling further action.
This could for example be used when wanting to set up a guard to trigger faster.

This overload does not require a `SuspiciousObject` to be called but can be called
with a float instead. The same rules about increasing beyond the maximum and
decreasing bellow the minimum still counts.
