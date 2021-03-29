using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    //instance for info use throughout scripts
    public static InventoryManager instance;
    //player Inventory
    public InventoryObject inventory;
    //playerHeldItem
    public HeldItemObject heldItem;

    private void Awake()
    {
        instance = this;
    }

    
    //inventory reset for now
    private void OnApplicationQuit()
    {
        inventory.Container.Clear();
    }
}
