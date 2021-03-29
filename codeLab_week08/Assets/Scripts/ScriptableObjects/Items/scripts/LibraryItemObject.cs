using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Library Item", menuName = "ScriptableObjects/Items/Library")]
public class LibraryItemObject : ItemObject
{
    private void Awake()
    {
        room = ItemRoom.Library;
    }
}
