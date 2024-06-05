using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class WeaponMelee : Weapon
{
    public PlayerVariables playerVariables;


    public WeaponMelee(int _damageAmount, Collider _weaponCollider)
    {
        DamageAmount = _damageAmount;
        weaponCollider = _weaponCollider;
    }
    void ActivateCollidersWeapon()
    {
        weaponCollider.enabled = true;
    }

    void DesactiveCollidersWeapon()
    {
        weaponCollider.enabled = false;
    }

    public override void Use(Vector3 direction)
    {
        playerVariables = PlayerVariables.instance;
        ActivateCollidersWeapon();
        DesactiveCollidersWeapon();
        if (weaponCollider == false)
        {
            Debug.Log("No hay nada");
        }
        else
        {
            Debug.Log("Si hay alguito");
        }
    }

    public override void LevelUp()
    {
        throw new System.NotImplementedException();
    }
}
