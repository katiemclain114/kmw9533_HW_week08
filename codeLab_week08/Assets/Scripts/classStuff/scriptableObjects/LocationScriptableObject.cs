using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Location", menuName = "ScriptableObjects/Locations", order = 0)]
public class LocationScriptableObject : ScriptableObject
{
    public string locName = "New Place";
    public string description = "default description";

    public LocationScriptableObject locationNorth;
    public LocationScriptableObject locationEast;
    public LocationScriptableObject locationSouth;
    public LocationScriptableObject locationWest;

}
