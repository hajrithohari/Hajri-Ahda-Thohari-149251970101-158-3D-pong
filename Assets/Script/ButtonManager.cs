using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("How To Play");
    }

    public void Play()
    {
        SceneManager.LoadScene("Game");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
