using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR

using UnityEditor;
#endif

public class AiEnemigo : MonoBehaviour
{
    // Start is called before the first frame update

    public Estados estado;
    public float distanciaSeguir;
    public float distanciaAtacar;
    public float distanciaEscapar;

    public bool autoSeleccionarTarget = true;
    public Transform target;
    public float distancia;


    public bool vivo = true;

    [Range(0, 100)]
    public float distanciaRango, distanciaAtacando, distanciaHuir;

    public void Awake()
    {
        if (autoSeleccionarTarget)
            target = GameObject.FindGameObjectWithTag("Playerr").transform;
        StartCoroutine(CalcularDistancia());
    }
    private void LateUpdate()
    {
        CheckEstado();
    }
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
            case Estados.atacar:
                EstadoAtacar();
                break;
            case Estados.muerto:
                EstadoMuerto();
                break;
            default:
                break;
        }


    }

    public void CambiarEstado(Estados e)
    {
        switch (e)
        {
            case Estados.idle:
                break;
            case Estados.seguir:
                break;
            case Estados.atacar:
                break;
            case Estados.muerto:
                vivo = false;
                break;
            default:
                break;
        }
        estado = e;
    }

    public virtual void EstadoIdle()
    {
        if (distancia < distanciaSeguir)
        {
            CambiarEstado(Estados.seguir);
        }
    }

    public virtual void EstadoSeguir()
    {
        if (distancia < distanciaAtacar)
        {
            CambiarEstado(Estados.atacar);
        }
        else if (distancia > distanciaEscapar && estado != Estados.muerto)
        {
            CambiarEstado(Estados.idle);
        }
    }

    public virtual void EstadoAtacar()
    {
        if (distancia > distanciaAtacar && estado != Estados.muerto)
        {
            CambiarEstado(Estados.seguir);
        }
    }
    public virtual void EstadoMuerto()
    {

    }

    IEnumerator CalcularDistancia()
    {
        while (vivo)
        {
            if (target != null)
            {
                distancia = Vector3.Distance(transform.position, target.position);

                yield return new WaitForSeconds(0.2f);
            }
        }
    }


#if UNITY_EDITOR
    private void OnDrawGizmosSelected()
    {

        Handles.color = Color.red;
        Handles.DrawWireDisc(transform.position, Vector3.up, distanciaAtacar);
        Handles.color = Color.yellow;
        Handles.DrawWireDisc(transform.position, Vector3.up, distanciaSeguir);
        Handles.color = Color.green;
        Handles.DrawWireDisc(transform.position, Vector3.up, distanciaEscapar);



    }
#endif


    private void OnDrawGizmos()
    {
        int icono = (int)estado;
        icono++;
        Gizmos.DrawIcon(transform.position + Vector3.up * 2.5f, "0" + icono + ".png", false);
    }

}

public enum Estados
{
    idle = 0,
    seguir = 1,
    atacar = 2,
    muerto = 3
}


