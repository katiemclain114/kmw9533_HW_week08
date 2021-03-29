using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//code for hold and combine button funcitons
public class HoldCombine : MonoBehaviour
{
    public GameObject holdButton;
    public GameObject combineButton;

    public ItemObject itemInfo;

    //turn of buttons at start
    private void Start()
    {
        holdButton.SetActive(false);
        combineButton.SetActive(false);
    }

    //turn on buttons on hover
    public void OnHover()
    {
        holdButton.SetActive(true);
        combineButton.SetActive(true);
    }
    
    //turn off buttons on exit
    public void OffHover()
    {
        holdButton.SetActive(false);
        combineButton.SetActive(false);
    }

    //set held item scriptable object when hold button clicked
    public void HoldClick()
    {
        InventoryManager.instance.heldItem.heldItem = itemInfo;
    }
}
