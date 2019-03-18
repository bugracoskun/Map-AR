using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public GameObject waypoint;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = waypoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(pos);
        waypoint.transform.position = new Vector3(pos[0], pos[1], pos[2]);

    }
}
