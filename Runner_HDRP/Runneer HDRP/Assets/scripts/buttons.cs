using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene(1);
    }

    public void openTutorial()
    {
        SceneManager.LoadScene(3);
    }

    public void openOptions()
    {
        SceneManager.LoadScene(4);
    }
    public void openCredits()
    {
        SceneManager.LoadScene(5);
    }
    public void quitButton()
    {
        Application.Quit();
    }

    public void returnToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void openHighscore()
    {
        SceneManager.LoadScene(2);
    }
}
