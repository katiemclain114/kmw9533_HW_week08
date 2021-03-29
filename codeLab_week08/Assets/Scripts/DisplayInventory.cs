using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInventory : MonoBehaviour
{
    //using inventory info
    public InventoryObject inventory;

    //names explain these pretty well
    public int X_SPACE_BETWEEN_ITEMS;
    public int Y_SPACE_BETWEEN_ITEMS;
    public int Number_OF_COLUMN;

    public int X_START;
    public int Y_START;

    //first time ive used a directory so idk if this is perfect. using to remember if item has been picked up
    //have to use because using update function
    private Dictionary<ItemObject, GameObject> itemDisplayed = new Dictionary<ItemObject, GameObject>();

    private void Start()
    {
        CreateDisplay();
    }

    private void Update()
    {
        UpdateDisplay();
    }

    public void CreateDisplay()
    {
        //goes through every item in inv
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            //creates scriptable objects ui in inventory menu
            var obj = Instantiate(inventory.Container[i].invImage, Vector3.zero, Quaternion.identity, transform);
            //set position in grid
            obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
            itemDisplayed.Add(inventory.Container[i], obj);
        }
    }

    
    //i think i want to change this to a function that is called when a new item is picked up 
    //instead of being called every frame with update
    public void UpdateDisplay()
    {
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (itemDisplayed.ContainsKey(inventory.Container[i]))
            {
                //do nothing if already picked up
            }
            else
            {
                //same as function above
                var obj = Instantiate(inventory.Container[i].invImage, Vector3.zero, Quaternion.identity, transform);
                obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                itemDisplayed.Add(inventory.Container[i], obj);
            }
            
        }
    }

    public Vector3 GetPosition(int i)
    {
        //used an equation to set the inventory on a specified grid (only works with ints)
        return new Vector3(X_START + (X_SPACE_BETWEEN_ITEMS * (i % Number_OF_COLUMN)),
            Y_START + (-Y_SPACE_BETWEEN_ITEMS * (i / Number_OF_COLUMN)), 0f);
    }
}
