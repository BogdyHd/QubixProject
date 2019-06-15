using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpAndDown : MonoBehaviour
{
    public GameObject ship;

    void Start()
    {
        
    }

    public void Slider_Changed(float newValue)
    {
        Vector3 pos = ship.transform.position;
        pos.z = newValue;
        ship.transform.position = pos;
    }

    // Update is called once per frame

    void Update()
    {
        
    }
}
