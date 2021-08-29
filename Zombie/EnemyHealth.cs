using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    
    public Animator anim;
    public EnemyHealth enem;
    public ParticleSystem muzzleFlash;
   
    public float health = 100f;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        enem = FindObjectOfType<EnemyHealth>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Damage(float amount)
    {
        muzzleFlash.Play();
        health -= amount;
        
        if (health <= 0)
        {
            
            // anim.SetBool("isWalking", false);
            anim.SetBool("isDead", true);
            GetComponent<AudioSource>().enabled=(false);
            //Destroy(gameObject,4f);
            GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
            return;
        }
        
    }
}
