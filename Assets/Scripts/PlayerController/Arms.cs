using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Arms : MonoBehaviour
{
    public BoxCollider[] armsSword;
    public BoxCollider hit;

    public GameObject[] amrs;

    void Start()
    {
        DesactiveCollidersArms();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            DesactivaArms();
        }
    }
    public void ActivateCollidersArms()
    {
        for (int i = 0; i < armsSword.Length; i++)
        {
            if()
        }
    }

    public void DesactiveCollidersArms()
    {
        for (int i = 0; i < armsSword.Length; i++)
        {
            armsSword[i].enabled = false;
        }

        hit.enabled = enabled;
    }
    
}
