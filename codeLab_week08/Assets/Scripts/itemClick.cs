using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemClick : MonoBehaviour
{
    //each item gets a scriptable object set to it
    public ItemObject item;
    
    //when clicked item is added to inv and destroy 
    private void OnMouseDown()
    {
        InventoryManager.instance.inventory.AddItem(item);
        Destroy(gameObject);
    }
}
