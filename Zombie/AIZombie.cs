using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIZombie : MonoBehaviour
{
     NavMeshAgent agent;
     Transform target;
      Animator anim;
     float distance;
    //public bool isAttacking = false;
   // bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, target.position);
        if(distance>2f)
        {
            agent.updatePosition = true;
            agent.SetDestination(target.position);
            anim.SetBool("isWalking",true);
            anim.SetBool("isAttacking", false);
        }
        else
        {
            agent.updatePosition = false;
            anim.SetBool("isWalking", false);
           // agent.velocity = Vector3.zero;
            anim.SetBool("isAttacking", true);
            //StartCoroutine(Health());
        }
    }
    //IEnumerator Health()
    //{
    //    yield return new WaitForSeconds(2f);

    //    if(isAttacking = true&&anim.SetBool("isAttacking",true));
        

    //    PlayerHealth.currentHealth -= 1;
    //    isAttacking = false;
    //}
}
