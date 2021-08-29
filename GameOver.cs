using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        PlayerLife.currentLife -= 1;
        if(PlayerLife.currentLife==0)
        {
            gameOver.SetActive(true);
        }
        else
       
        SceneManager.LoadScene(2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
