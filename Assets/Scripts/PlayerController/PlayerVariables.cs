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
    
    public List<Weapon> weapons;
    public Weapon currentWeapon;
    private int _currentIndex;

    public void NextWeapon()
    {
        _currentIndex++;
        _currentIndex %= weapons.Count;
        currentWeapon = weapons[_currentIndex];
    }

    public void PrevWeapon()
    {
        _currentIndex--;
        _currentIndex %= weapons.Count;
        currentWeapon = weapons[_currentIndex];
    }

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
