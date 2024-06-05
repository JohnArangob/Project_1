using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public abstract class Weapon
{
    private string nombre;
    private int damageAmount;
    private int level;
    public Collider weaponCollider;

    public string Nombre { get; set; }

    public int DamageAmount { get => damageAmount; set => damageAmount = value; }

    public int Level { get => level; set => level = value; }

    public abstract void Use(Vector3 direction);
    public abstract void LevelUp();
}
