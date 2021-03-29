using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Cigar Lounge Item", menuName = "ScriptableObjects/Items/CigarLounge")]
public class CigarLoungeItemObject : ItemObject
{
    public void Awake()
    {
        room = ItemRoom.CigarLounge;
    }
}
