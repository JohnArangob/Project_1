using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int vida = 100;

    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("La vida es: " + vida);
    }

    // Update is called once per frame
    void Update()
    {

    }
    //public void TakeDamage(int damage)
    //{
        ///health -= damage;
        //if (health <= 0)
        //{
        //Died();
        //}
    //}
    //private void Died()
    //{
        //gameObject.SetActive(false);
    //}
}
