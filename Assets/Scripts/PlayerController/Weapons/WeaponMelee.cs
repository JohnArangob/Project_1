using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponMelee : Weapon
{
    

    void Use()
    {

    }
    void ActivateCollidersArms()
    {
        
    }

    void DesactiveCollidersArms()
    {
           
    }

    public override void Use(Vector3 direction)
    {
        ActivateCollidersArms();
    }

    public override void nose()
    {
        DesactiveCollidersArms();
    }

    public override int DamageAmount(Vector3 position)
    {
        return damageAmount;
    }
}
