using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieGirlHealth : MonoBehaviour
{

    public Animator anim;
    public zombieGirlHealth enem1;
    public ParticleSystem muzzleFlash;

    public float healthh = 100f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        enem1 = FindObjectOfType<zombieGirlHealth>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Damagee(float amountt)
    {
   
        muzzleFlash.Play();
        healthh -= amountt;

        if (healthh <= 0)
        {

            anim.SetBool("isWalking", false);
            anim.SetBool("isDead", true);
            GetComponent<AudioSource>().enabled = (false);
            //Destroy(gameObject, 4f);
            GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
            return;
        }

    }
}
