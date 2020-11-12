using System;
using System.Collections;
using UnityEngine;

public class Background : MonoBehaviour
{

    void Start()
    {
        GetComponent<Camera>().backgroundColor = Color.black;
        GetComponent<Camera>().backgroundColor = Color.white;
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(Color.black);
        }

        if (Input.GetMouseButtonUp(1))
        {
            Debug.Log(Color.white);
        }
    }
}