using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour {

    public GameObject sun;
    public GameObject mercury;
    public GameObject venus;
    public GameObject earth;
    public GameObject mars;
    public GameObject jupiter;
    public GameObject saturn;
    public GameObject uranus;
    public GameObject neptune;

    public bool isChanged = false;

    private GameObject player;

    public void ChangePlanet(int planetID)
    {
        switch (planetID)
        {

            case 1:
                player = sun;
                isChanged = true;
                break;
            case 2:
                player = mercury;
                isChanged = true;
                break;
            case 3:
                player = venus;
                isChanged = true;
                break;
            case 4:
                player = earth;
                isChanged = true;
                break;
            case 5:
                player = mars;
                isChanged = true;
                break;
            case 6:
                player = jupiter;
                isChanged = true;
                break;
            case 7:
                player = saturn;
                isChanged = true;
                break;
            case 8:
                player = uranus;
                isChanged = true;
                break;
            case 9:
                player = neptune;
                isChanged = true;
                break;
            default:
                player = sun;
                break;
        }
    }

    public GameObject GetPlanet()
    {
        return player;
    }

    public bool GetIsChanged()
    {
        return isChanged;
    }
}



