using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class WeaponDistance : Weapon
{
    public PlayerVariables playerVariables;
    private Projectile _proyectile;

    //Constructor
    public WeaponDistance(int _damageAmount)
    {
        DamageAmount = _damageAmount;

    }

    public override void LevelUp()
    {
        throw new System.NotImplementedException();
    }

    public override void Use(Vector3 direction)
    {
        _proyectile = new Projectile(DamageAmount);
        playerVariables = PlayerVariables.instance;


        GameObject projectile = UnityEngine.GameObject.Instantiate(PlayerVariables.instance.projectilePrefab, PlayerVariables.instance.shootPoint.position, Quaternion.identity);


        Projectile projectileComponent = projectile.GetComponent<Projectile>();
        if (projectileComponent != null)
        {
            projectileComponent.damage = DamageAmount;
            projectileComponent.speed = 10f;
        }
        projectile.transform.forward = direction;

    }
}
