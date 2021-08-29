using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    
    void Update()
    {

    }
    public void PlayGame()
    {
        StartCoroutine(NewGame());
    }
    IEnumerator NewGame()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(1);
    }
    //public void QuitGame()
    //{
    //    UnityEditor.EditorApplication.isPlaying = false;
    //    Application.Quit();
    //}
}
