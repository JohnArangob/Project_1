using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]
public class Enemy1 : AiEnemigo
{
    private NavMeshAgent agente;
    public Animator animaciones;

    new void Awake()
    {
        base.Awake();
        agente = GetComponent<NavMeshAgent>();
    }
    public override void EstadoIdle()
    {
        base.EstadoIdle();
        if (animaciones != null)
        {
            animaciones.SetFloat("velocidad", 0);
        }
        if (animaciones != null)
        {
            animaciones.SetBool("atacando", false);
            agente.SetDestination(transform.position);
        }

    }

    public override void EstadoSeguir()
    {
        base.EstadoSeguir();
        if (animaciones != null)
        {
            animaciones.SetFloat("velocidad", 0.5F);
        }
        if (animaciones != null)
        {
            animaciones.SetBool("atacando", false);
            agente.SetDestination(target.position);


        }
    }

    public override void EstadoAtacar()
    {
        base.EstadoAtacar();
        if (animaciones != null)
        {
            animaciones.SetFloat("velocidad", 1);
            animaciones.SetBool("atacando", true);
            agente.SetDestination(transform.position);
            transform.LookAt(target, Vector3.up);
        }

    }

    public override void EstadoMuerto()
    {
        base.EstadoMuerto();
        agente.enabled = false;
    }
}
