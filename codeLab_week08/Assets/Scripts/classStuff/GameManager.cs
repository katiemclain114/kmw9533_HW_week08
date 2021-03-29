using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public LocationScriptableObject currentLoc;
    public Text locNameText;
    public Text locDescription;

    public GameObject buttonNorth;
    public GameObject buttonEast;
    public GameObject buttonSouth;
    public GameObject buttonWest;
    private void Start()
    {
        UpdateLoc();
    }
    
    public void MoveDirection(int dir)
    {
        switch (dir)
        {
            case 0:
                currentLoc = currentLoc.locationNorth;
                break;
            case 1:
                currentLoc = currentLoc.locationEast;
                break;
            case 2:
                currentLoc = currentLoc.locationSouth;
                break;
            case 3:
                currentLoc = currentLoc.locationWest;
                break;
            default:
                
                break;
        }
        
        UpdateLoc();
    }

    void UpdateLoc()
    {
        locNameText.text = currentLoc.locName;
        locDescription.text = currentLoc.description;

        if (currentLoc.locationNorth == null)
        {
            buttonNorth.SetActive(false);
        }
        else
        {
            currentLoc.locationNorth.locationSouth = currentLoc;
            buttonNorth.SetActive(true);
        }

        if (currentLoc.locationEast == null)
        {
            buttonEast.SetActive(false);
        }
        else
        {
            currentLoc.locationEast.locationWest = currentLoc;
            buttonEast.SetActive(true);
        }

        if (currentLoc.locationSouth == null)
        {
            buttonSouth.SetActive(false);
        }
        else
        {
            currentLoc.locationSouth.locationNorth = currentLoc;
            buttonSouth.SetActive(true);
        }

        if (currentLoc.locationWest == null)
        {
            buttonWest.SetActive(false);
        }
        else
        {
            currentLoc.locationWest.locationEast = currentLoc;
            buttonWest.SetActive(true);
        }
    }
}
