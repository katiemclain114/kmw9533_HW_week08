using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Created Item", menuName = "ScriptableObjects/Items/Created")]
public class CreatedItemObject : ItemObject
{
    private void Awake()
    {
        room = ItemRoom.Created;
    }
}
