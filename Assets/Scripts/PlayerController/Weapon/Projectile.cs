using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int damage;
    public float speed;


    void Start()
    {
        // Inicializar la velocidad del proyectil
        GetComponent<Rigidbody>().velocity = transform.forward * speed;

    }
    public Projectile(int _damage)
    {
        damage = _damage;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Si colisiona con un enemigo, aplicar da�o
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Obtener el componente de vida del enemigo y aplicar da�o
            //collision.gameObject.GetComponent<EnemyHealth>().TakeDamage(damage);

            // Destruir el proyectil despu�s de aplicar da�o
            Destroy(gameObject);
            Debug.Log("Es: " + damage);
        }
    }
}
