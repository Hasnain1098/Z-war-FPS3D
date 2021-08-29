using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip FireSound;
    public static AudioClip hurtSound;
    public static AudioSource src;

    // Start is called before the first frame update
    void Start()
    {
        FireSound = Resources.Load<AudioClip>("Fire1");
        src = GetComponent<AudioSource>();
        hurtSound = Resources.Load<AudioClip>("hurt");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound(string clipName)
    {
        switch (clipName)
        {
            case "Fire":
                src.PlayOneShot(FireSound);
                break;
            case "hurt":
                src.PlayOneShot(hurtSound);
                break;
        }

    }

}
