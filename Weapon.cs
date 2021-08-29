using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Weapon : MonoBehaviour
{

    public float fireRate, damageAmount, damageAmountt;
    public float nextFire;
     string hitTag;
     EnemyHealth enem;
     zombieGirlHealth enem1;
    ZombieMonsterHealth enem2;
    ZombiescoutHealth enem3;
    [Header("AmmoManagement")]
    public int ammoCount;
    public int availableAmmo;
    public int maxAmmo;
    public Text currentAmmo;
    public Animator anim;
    public ParticleSystem muzzleFlash;
    


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        enem = FindObjectOfType<EnemyHealth>();
        enem1= FindObjectOfType<zombieGirlHealth>();
        enem2= FindObjectOfType<ZombieMonsterHealth>();
        enem3= FindObjectOfType<ZombiescoutHealth>();

    }

    // Update is called once per frame
    public void Update()
    {
        currentAmmo.text = ammoCount.ToString();
        if(ammoCount<=0)
        {
            anim.SetBool("Reload", true);
            return;
        }
        
            
        if (Input.GetButton("Fire1")&&Time.time>=nextFire)
        {
                anim.SetTrigger("Fire");
            
            nextFire = Time.time + 1f / fireRate;
            Raycasting();
            muzzleFlash.Play();     
            SoundManager.PlaySound("Fire");
        }
    }
    void Raycasting()
    {
        ammoCount--;
        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out hit))
        {
            hitTag = hit.transform.tag;
        }
        if(hit.collider!=null)
        {
            //Debug.Log(hit.transform.gameObject.tag);
            if (hitTag == "Enemy")
            {
                enem.Damage(damageAmount);
                
            }
             if (hitTag == "Enemy1")
            {
                enem1.Damagee(damageAmountt);
                Debug.Log(hit.transform.tag);

            }
            if (hitTag == "Enemy2")
            {
                enem2.Damage(damageAmount);
                Debug.Log(hit.transform.tag);

            }
            if (hitTag == "Enemy3")
            {
                enem3.Damage(damageAmount);
                Debug.Log(hit.transform.tag);

            }
        }
        
    }
    public void Reloading()
    {
        availableAmmo -= maxAmmo - ammoCount;
        ammoCount = maxAmmo;
        anim.SetBool("Reload", false);
    }
}
