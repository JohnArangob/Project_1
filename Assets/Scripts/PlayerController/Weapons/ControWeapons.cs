using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ControWeapons : MonoBehaviour
{
    private PlayerVariables playerVariables;
    private int _currentIndex;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            playerVariables.currentWeapon?.Use(transform.forward);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            playerVariables.NextWeapon();
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            playerVariables.PrevWeapon();
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (playerVariables.currentWeapon != null)
            playerVariables.currentWeapon.damageAmount += 2;

        foreach(Weapon weapon in playerVariables.weapons)
        {
            weapon.damageAmount += 3;
        }



        // Ejemplo recibir dano

        if (collision.gameObject.TryGetComponent<Weapon>(out Weapon weapon1))
        {
            playerVariables.hp -= weapon1.DamageAmount(transform.position);
        }
    }
}
