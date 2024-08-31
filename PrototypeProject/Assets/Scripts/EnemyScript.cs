using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private int HP = 100;
    public Animator animator;

    public void TakeDamage(int damageAmount)
    {
        HP-= damageAmount;
        if (HP <= 0)
        {
            animator.SetTrigger("death");
            GetComponent<Collider>().enabled = false;

        }
        else
        {
            animator.SetTrigger("damage");
        }
    }
}
