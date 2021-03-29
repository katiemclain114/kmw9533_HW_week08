using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract  class ItemObject : ScriptableObject
{
    //different items can have specific room tag set
    public enum ItemRoom
    {
        CigarLounge,
        Library,
        Created
    }

    //only important variable right now is invImage
    //image for the inventory UI
    public GameObject invImage;
    //later i can use item sprite render to set specific image
    public Sprite itemImage;
    public ItemRoom room;
    [TextArea(15, 20)]
    public string description;

}
