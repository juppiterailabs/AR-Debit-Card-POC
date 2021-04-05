using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbButton1 : MonoBehaviour, IVirtualButtonEventHandler {

    // Start is called before the first frame update
    void Start()
    {
        
    }

     public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button pressedddddddddd");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button releaseddddddddddd");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
