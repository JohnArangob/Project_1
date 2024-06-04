using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ControlWeapon : MonoBehaviour
{
    //public PlayerVariables playerVariables;
    private int _currentIndex;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            PlayerVariables.instance.currentWeapon?.Use(transform.forward);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            PlayerVariables.instance.NextWeapon();
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            PlayerVariables.instance.PrevWeapon();
        }
    }


   
}
