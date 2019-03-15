using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class constraint : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public Vector2 xCon;
    public Vector2 yCon;
    public Vector2 zCon;

    void Start()
    {
        //I hope this Works!!!
    }

    void Update()
    {
        transform.localPosition = new Vector3(Mathf.Clamp(transform.localPosition.x, xCon.x, xCon.y), Mathf.Clamp(transform.localPosition.y, yCon.x, yCon.y), Mathf.Clamp(transform.localPosition.z, zCon.x, zCon.y));
        if (transform.localPosition.x < xCon.x)
        {
            transform.Translate(xCon.x, transform.localPosition.y, transform.localPosition.z);
        }
        if (transform.localPosition.x > xCon.y)
        {
            transform.Translate(xCon.y, transform.localPosition.y, transform.localPosition.z);
        }
        if (transform.localPosition.y < yCon.x)
        {
            transform.Translate(transform.localPosition.x, yCon.x, transform.localPosition.z);
        }
        if (transform.localPosition.y > yCon.y)
        {
            transform.Translate(transform.localPosition.x, yCon.y, transform.localPosition.z);
        }
        if (transform.localPosition.z < zCon.x)
        {
            transform.Translate(transform.localPosition.x, transform.localPosition.y, zCon.x);
        }
        if (transform.localPosition.z > zCon.y)
        {
            transform.Translate(transform.localPosition.x, transform.localPosition.y, zCon.y);
        }
    }
}
