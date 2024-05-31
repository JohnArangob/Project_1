using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Weapon
{
    public int damageAmount;

    public abstract void Use(Vector3 direction);
    public abstract void nose();
    

    public abstract int DamageAmount(Vector3 position);

}
