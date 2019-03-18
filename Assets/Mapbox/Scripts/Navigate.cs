using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Navigate : MonoBehaviour
{
    public GameObject direction;
    public GameObject ScriptManager;

    public void Direction_Appear()
    {
        
            direction.SetActive(true);
        

    }

    public void script_on()
    {
        ScriptManager.SetActive(true);
    }
}
