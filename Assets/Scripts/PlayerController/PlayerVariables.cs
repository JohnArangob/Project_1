using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVariables : MonoBehaviour
{
    Movements movements;

    public float speed = 5f;
    public float rotationSpeed = 720f;
    public float movInX;
    public float movInZ;
    public int hp;
    public int damageSword;
    public int damageDistance;
    public Animator anim;

    private void Start()
    {
        movements = GetComponent<Movements>();
    }

    private void Update()
    {
        movInX = movements.mX;
        movInZ = movements.mZ;
    }
}
