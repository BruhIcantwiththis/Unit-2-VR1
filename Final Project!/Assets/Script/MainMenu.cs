using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void Retry()
    {
        SceneManager.LoadScene(1);
    }
    public void Update()
    {
        if (BadTimeTimer.DieTime == true)
            Debug.Log("Uh oh");
    }
    public void Main()
    {
        SceneManager.LoadScene(5);
    }
    public void FullBright()
    {
        UIon = false;
    }
}
