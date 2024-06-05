using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System;


#if UNITY_EDITOR
using UnityEditor;
#endif
[CreateAssetMenu(fileName = "Enemy", menuName = "Enemys/Base")]
public class EnemyCharacter : ScriptableObject
{
    public Estados estado;
    //public Transform enemy;
    public float distanciaSeguir;
    public float distanciaAtacar;
    public float distanciaEscapar;



    public void CheckEstado()
    {
        switch (estado)
        {
            case Estados.idle:
                EstadoIdle();
                break;
            case Estados.seguir:
                EstadoSeguir();
                break;
            case Estados.attack:
                EstadoAtacar();
                break;
            case Estados.dead:
                EstadoMuerto();
                break;
            default:
                break;
        }
        return;
    }
    public void CambairEstado(Estados e)
    {
        switch (e)
        {
            case Estados.idle:
                break;
            case Estados.seguir:
                break;
            case Estados.attack:
                break;
            case Estados.dead:
                break;
            default:
                break;
        }
        estado = e;
    }
    public virtual void EstadoIdle()
    {
        return;
    }
    public virtual void EstadoAtacar()
    {
        return;
    }
    public virtual void EstadoSeguir()
    {
        return;
    }
    public virtual void EstadoMuerto()
    {
        return;
    }
#if UNITY_EDITOR
    public void OnDrawGuizmosSelected(Transform enemy)
    {
            Handles.color = Color.yellow;
            Handles.DrawWireDisc(enemy.position, Vector3.up, distanciaSeguir);
            Handles.color = Color.red;
            Handles.DrawWireDisc(enemy.position, Vector3.up, distanciaAtacar);
            Handles.color = Color.green;
            Handles.DrawWireDisc(enemy.position, Vector3.up, distanciaEscapar);
    }
#endif
    public void OnDrawGuizmos(Transform enemy)
    {
        int icono = (int)estado;
        icono++;
        Gizmos.DrawIcon(enemy.position + Vector3.up * 1.2f, "01.png", false);
    }
}

[Serializable]
public enum Estados
{
    idle    = 0,
    seguir  = 1,
    attack  = 2,
    dead    = 3,
}
