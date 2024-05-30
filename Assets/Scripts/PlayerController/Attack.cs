using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private PlayerVariables sistemattack;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "swordimpact")
        {
            if (sistemattack.anim != null)
            {
                sistemattack.anim.Play("Enemy");
            }

            sistemattack.hp -= sistemattack.damageSword;
        }
        if (other.gameObject.tag == "distanceimpact")
        {
            if (sistemattack.anim != null)
            {
                sistemattack.anim.Play("Enemy");
            }

            sistemattack.hp -= sistemattack.damageSword;
        }

        if (sistemattack.hp <=0)
        {
         Destroy(gameObject);   
        }
    }
}
