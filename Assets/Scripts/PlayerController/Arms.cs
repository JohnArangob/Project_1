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

    public void DesactiveCollidersArms()
    {
        for (armsSword[i] != null)
        {
            armsSword[i].enabled = false;
        }

        hit.enabled = enabled;
    }
    
}
