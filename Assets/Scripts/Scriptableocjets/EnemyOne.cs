using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class EnemyOne : MonoBehaviour
{
    public EnemyCharacter enemyCharacter;
    public Transform player;
    public EnemyCharacter enemyCharacterData;

    void Start()
    {
        enemyCharacter = enemyCharacterData;
        OnDrawGizmosSelected();
    }
    void Update()
    {

    }
    private void LateUpdate()
    {
        enemyCharacter.CheckEstado();
    }
#if UNITY_EDITOR
    private void OnDrawGizmosSelected() => enemyCharacter.OnDrawGuizmosSelected(player);


#endif
}

