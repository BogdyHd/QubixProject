using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public float speed = 6;
    private float zatstart = 0;
    private float xatstart = 0;
    private float hzMovement = 0, vtMovement = 0;
    public Button calibrate;
    public Toggle accel;



    private Rigidbody rg;


    // Start is called before the first frame update
    void Start()
    {
        calib();
        rg = GetComponent<Rigidbody>();
        Debug.Log(xatstart);
        Debug.Log(zatstart);
    }

    // Update is called once per frame
    void Update()
    {
        calibrate.onClick.AddListener(calib);
        
            hzMovement = Input.acceleration.x - xatstart;
            vtMovement = -Input.acceleration.z + zatstart;
        
     
        //Vector3 v = new Vector3(hzMovement, 0, vtMovement);
        //rg.AddForce(v * speed);
    


    rg.transform.Translate(hzMovement, -vtMovement, 0);
        //  rg.transform.RotateAround(Vector3.zero, Vector3.up * Input.acceleration.x, 20 * Time.deltaTime);

    }

   

    void calib()
    {
        xatstart = Input.acceleration.x;
        zatstart = Input.acceleration.z;
    }
}
