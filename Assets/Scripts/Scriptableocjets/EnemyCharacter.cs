using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "Enemys/Base")]
public class EnemyCharacter : ScriptableObject
{
    public string name;
    public int healt;
    public int attack;
    public int velocity;
}
