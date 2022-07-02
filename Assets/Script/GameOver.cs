using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private GoalManager manager;

    private void Start()
    {
        manager = FindObjectOfType<GoalManager>();
    }

    private void Update()
    {
        WinCondition();
    }

    private void WinCondition()
    {
        if(GameObject.FindGameObjectsWithTag("Player").Length == 1)
        {
            Winner();
            SceneManager.LoadScene("Game Over");
        }
    }


    private void Winner()
    {
        if (manager.player[0].GetComponent<PaddleController>().playerHP != 0)
        {
            PlayerPrefs.SetString("winner", "Player 4");
        }
        if (manager.player[1].GetComponent<PaddleController>().playerHP != 0)
        {
            PlayerPrefs.SetString("winner", "Player 3");
        }
        if (manager.player[2].GetComponent<PaddleController>().playerHP != 0)
        {
            PlayerPrefs.SetString("winner", "Player 2");
        }
        if (manager.player[3].GetComponent<PaddleController>().playerHP != 0)
        {
            PlayerPrefs.SetString("winner", "Player 1");
        }
    }
}
