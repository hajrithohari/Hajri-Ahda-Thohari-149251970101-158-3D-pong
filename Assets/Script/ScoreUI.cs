using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public Text player1;
    public Text player2;
    public Text player3;
    public Text player4;

    public GoalManager manager;

    private void Update()
    {
        ScoreText();
    }

    private void ScoreText()
    {
        player1.text = manager.player[3].GetComponent<PaddleController>().playerHP.ToString();
        player2.text = manager.player[2].GetComponent<PaddleController>().playerHP.ToString();
        player3.text = manager.player[1].GetComponent<PaddleController>().playerHP.ToString();
        player4.text = manager.player[0].GetComponent<PaddleController>().playerHP.ToString();
    }
}
