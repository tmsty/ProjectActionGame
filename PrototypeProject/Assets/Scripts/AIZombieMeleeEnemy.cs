using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIZombieMeleeEnemy : MonoBehaviour
{
    Transform target;
    NavMeshAgent agent;
    public float lookRadius;
    public Animator anim;
    public float timeReload = 0;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = PlayerManager.instance.player.transform;
    }

    private void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance <= lookRadius)
        {
            anim.SetBool("isRun", true);
            agent.SetDestination(target.position);

            if (distance <= agent.stoppingDistance)
            {
                anim.SetBool("isFight", true);
                timeReload += 0.01f;
                if (timeReload >= 5f)
                {
                    timeReload = 0;
                }
                LookTarget();
            }
            else
            {
                anim.SetBool("isFight", false);
            }
        }
        else
        {
            anim.SetBool("isRun", false);
        }
        
    }

    void LookTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation,lookRotation, Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
