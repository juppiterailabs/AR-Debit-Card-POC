using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbButton : MonoBehaviour, IVirtualButtonEventHandler {

    public GameObject vbBtnObj;
    public GameObject Account_Data;


 // Use this for initialization
 void Start () {
        vbBtnObj = GameObject.Find("LacieBtn");

        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        Account_Data = GameObject.Find("Transactions");
        Account_Data.active = false;
 }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button pressed");
        Account_Data.active = true;
        // Trans.transform.position = new Vector3(0,0, 1);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button released");
        Account_Data.active = false;
    }
}