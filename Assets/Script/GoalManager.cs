using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
    public List<GameObject> player;

    private void Update()
    {
        PlayerInactive();
    }

    public void PlayerInactive()
    {
        if (player[0].GetComponent<PaddleController>().playerHP == 0)
        {
            player[0].SetActive(false);
        }
        if (player[1].GetComponent<PaddleController>().playerHP == 0)
        {
            player[1].SetActive(false);
        }
        if (player[2].GetComponent<PaddleController>().playerHP == 0)
        {
            player[2].SetActive(false);
        }
        if (player[3].GetComponent<PaddleController>().playerHP == 0)
        {
            player[3].SetActive(false);
        }

    }
}
