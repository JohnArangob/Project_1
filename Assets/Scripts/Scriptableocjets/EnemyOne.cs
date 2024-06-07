using UnityEngine;
#if UNITY_EDITOR
#endif
public class EnemyOne : MonoBehaviour 
{
    public EnemyCharacter enemyCharacter;
    public Transform player;

    void Start()
    {
        enemyCharacter.Position(player);
        StartCoroutine(enemyCharacter.CalculateDistance(transform));
    }

    private void LateUpdate()
    {
        enemyCharacter.CheckEstado();
    }
    
#if UNITY_EDITOR

    private void OnDrawGizmos()
    {
        enemyCharacter.OnDrawGuizmosSelected(player);
    }

#endif

}

