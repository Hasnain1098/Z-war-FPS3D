using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public Text playerLives;
    public static int currentLife = 3;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        playerLives.GetComponent<Text>().text = currentLife.ToString();
    }
}
