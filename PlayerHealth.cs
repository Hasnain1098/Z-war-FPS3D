using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    
    Rigidbody rb;
    public Text playerHealth;
    public static int currentHealth = 100;
    PlayerHealth health;
    [SerializeField]
    int maxHealth = 100;
    // Start is called before the first frame update
    void Start()
    {
       
        rb = GetComponent<Rigidbody>();
       health = FindObjectOfType<PlayerHealth>();
        currentHealth = maxHealth;
    }

    void Update()
    {
        //GameObject.FindGameObjectWithTag("Enemy");
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        else
            playerHealth.GetComponent<Text>().text = currentHealth.ToString() + "%";
    }
    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "DMG")
        {
            currentHealth -= 10;
            SoundManager.PlaySound("hurt");
            Debug.Log("print");
        }
    }
}
