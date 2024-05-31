using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons
{
    private PlayerVariables sistemattack;

    void Used()
    {
        void OnUsed(Collider other)
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

            if (sistemattack.hp <= 0)
            {

            }
        }
    }
    
}
