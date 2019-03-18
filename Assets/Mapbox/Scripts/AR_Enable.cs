using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR_Enable : MonoBehaviour
{
    public GameObject Focus;
    public GameObject WorldAR;
    public GameObject cameras;
    public GameObject events;
    public GameObject location;
    public GameObject panel;
    public GameObject acceptbutton;


    public void Toggle_Changed(bool newValue)
    {
        if (cameras.activeSelf == true)
        {
            events.SetActive(false);
            location.SetActive(false);
            panel.SetActive(false);
            acceptbutton.SetActive(false);

            WorldAR.SetActive(true);
            Focus.SetActive(true);



        }

    }
}
