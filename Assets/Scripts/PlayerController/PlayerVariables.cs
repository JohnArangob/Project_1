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
    public Animator anim;
    
    public List<Weapon> weapons = new List<Weapon>();
    public Weapon currentWeapon;
    private int _currentIndex;

    public GameObject projectilePrefab;
    public Transform shootPoint;

    public GameObject weaponObjec;
    private Collider _WeaponCollider;

    public HealthEnemy _enemyHp;
    public int health = 100;
    //public int EnemyHealth { get => enemyHealth; set => enemyHealth = value; }

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
    void Start()
    {
        _WeaponCollider = weaponObjec.GetComponent<Collider>();

        movements = GetComponent<Movements>();
        weapons.Add(new WeaponDistance(20));
        weapons.Add(new WeaponMelee(50, _WeaponCollider));

        _enemyHp = new HealthEnemy(health);
       
        

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

  
     void Update()
    {
        movInX = movements.mX;
        movInZ = movements.mZ;
    }
}
