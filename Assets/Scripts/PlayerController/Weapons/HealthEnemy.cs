using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthEnemy : MonoBehaviour
{
    private int damage;
    private float health = 10;
    public HealthEnemy(int _damage) => Damage = _damage;

    public int Damage { get => damage; set => damage = value; }

    void Start()
    {
        Debug.Log("Es: " + health + Damage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
