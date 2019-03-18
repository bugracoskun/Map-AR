using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArEnable : MonoBehaviour
{
    public GameObject cameraa;
    public GameObject events;
    public GameObject navigatebutton;
    public GameObject worldscale;
    public GameObject focuss;
    public GameObject location;


    public void Toggle_Changed(bool newValue)
    {
        if (cameraa.activeSelf == true)
        {
            events.SetActive(false);
            navigatebutton.SetActive(false);
            location.SetActive(false);
            cameraa.SetActive(false);

            worldscale.SetActive(true);
            focuss.SetActive(true);
        }
        else if (cameraa.activeSelf == false)
        {
            events.SetActive(true);
            navigatebutton.SetActive(true);
            location.SetActive(true);
            cameraa.SetActive(true);

            worldscale.SetActive(false);
            focuss.SetActive(false);
        }



        

    }
}
