using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public int damageCount = 20;

    public void OnCollisionEnter(Collision collision)
    {
        PlayerManager.Damage(damageCount);
    }
}
