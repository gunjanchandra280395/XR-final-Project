﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    Animator animator;
    bool doorOpen;
    void Start()
    {
        doorOpen = false;
        animator = GameObject.Find("DoorParent").GetComponent< Animator>();
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Key")
        {
            doorOpen = true;
            DoorsControl ("Open");
        }
    }

    void OnTriggerExit(Collider col)
    {
        if(doorOpen)
        {
            doorOpen = false;
            DoorsControl ("Close");
        }
    }

    void DoorsControl(string direction)
    {
        animator.SetTrigger(direction);
    }
}
