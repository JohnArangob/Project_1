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

    [Header("Weapon")]
    public List<Weapon> weapons = new List<Weapon>();
    public Weapon currentWeapon;
    private int _currentIndex;

    [Header("WeaponDistance")]
    public GameObject projectilePrefab;
    public Transform shootPoint;

    [Header("WeaponMelee")]
    public GameObject weaponObjec;
    private Collider _WeaponCollider;


    public static PlayerVariables instance;



    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }
    private void Start()
    {
        _WeaponCollider = weaponObjec.GetComponent<Collider>();

        movements = GetComponent<Movements>();
        attack = GetComponent<Attack>();
        playerLoctions = GetComponent<PlayerLoctions>();

        weapons.Add(new WeaponDistance(20));
        weapons.Add(new WeaponMelee(50, _WeaponCollider));
    }
    public void NextWeapon()
    {
        _currentIndex++;
        _currentIndex %= weapons.Count;
        currentWeapon = weapons[_currentIndex];
    }

    public void PrevWeapon()
    {
        _currentIndex = _currentIndex - 1 + weapons.Count;
        _currentIndex %= weapons.Count;
        currentWeapon = weapons[_currentIndex];
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
