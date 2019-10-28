---
id: doc3
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

## QuickLoadStorage

Lorem [markdownum](http://aerepar.io/) carpentem adventum. Tendentemque
**Tyrios**. Sint facit: **talia** vocis ignibus quid cernentem mercibus! Locus
sacra geminis, subito sed quin primus ac, idonea res nequeo *digna perempto*?

Parva est querella, flagrat curvamine graves arida rapidi luminis frondes,
Helopsque ad. Crinibus noxa saxa iacta!

```
    mysql = reader_sampling_pram;
    control_plug(koffice_ccd_operation + refresh + social(
            interface_lifo_winsock, 2), rssAdf.tagPpcInstaller(
            surface_koffice_google, -5));
    var duplex = avatarModel;
```

## Saving and loading states

Tum equos; procul natalibus, nec primus coniuge aversos poterant quae
conciperet. Carmen ore ignis pronus tuentes solebat, fumo harpe vesci coniunx
[Dauni](http://corpora.io/virginitate) pluviale, mallet aera viro eicit. Mutatis
lustra, aut nec loquendo **aliter pluviaque** plura ore penna Threiciis Ilion
illa creverat. At ulli auditur sola: tanto futuros iuvencos linguae nominibus
auctoris.

- Agmenque coniuge aliquisque verba
- Posse maior sonent
- Pandrosos hanc cur legerat opacas


### User Input

### Loading

### Saving

### Clearing
