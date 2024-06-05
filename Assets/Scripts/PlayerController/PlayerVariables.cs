using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVariables : MonoBehaviour
{
    Movements movements;
    Attack attack;
    PlayerLoctions playerLoctions;
    [Header("Movement")]
    public float speed = 5f;
    public float rotationSpeed = 1400f;
    public float movInX;
    public float movInZ;

    [Header("Health")]
    public float health;

    [Header("Positions")]
    public bool stayWhitBoss;

    [Header("Dash")]
    public float dashForce;
    public float dashCooldown;
    public float dashTime;
    public float dashTimer;
    public bool isDashing;
    public bool unLockDash;



    private void Start()
    {
        movements = GetComponent<Movements>();
        attack = GetComponent<Attack>();
        playerLoctions = GetComponent<PlayerLoctions>();
    }

    private void Update()
    {
        movInX = movements.mX;
        movInZ = movements.mZ;
        unLockDash = movements.unlockDash;
        health = attack.health;
        stayWhitBoss = playerLoctions.ZonaBoss;
    }
}
