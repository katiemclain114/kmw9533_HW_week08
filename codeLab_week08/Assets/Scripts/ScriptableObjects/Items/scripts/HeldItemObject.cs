using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "HeldItem", menuName = "ScriptableObjects/Items/HeldItem")]
public class HeldItemObject : ScriptableObject
{
    //boring but keeps track of held item
    public ItemObject heldItem;
}
