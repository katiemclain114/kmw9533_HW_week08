using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inv", menuName = "ScriptableObjects/Inventory")]
public class InventoryObject : ScriptableObject
{
    //keeps list of items in inventory
    public List<ItemObject> Container = new List<ItemObject>();

    //can be called when item added
    public void AddItem(ItemObject item)
    {
        Container.Add(item);
    }
}
