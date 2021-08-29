using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiesCont : MonoBehaviour
{
    public GameObject Zombie;
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(Zombie, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
        }
    }
}
