using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private bool isVertical;
    [SerializeField]
    private bool isRight;

    public GoalManager manager;

    private void OnTriggerEnter(Collider other)
    {
        Goal();
    }

    public void Goal()
    {
        if (isVertical && isRight)
        {
            if (manager.player[0].GetComponent<PaddleController>().playerHP > 0)
            {
                manager.player[0].GetComponent<PaddleController>().playerHP--;
            }
            else
            {
                this.gameObject.GetComponent<Collider>().isTrigger = false;
            }
        }
        if (isVertical && !isRight)
        {
            if (manager.player[1].GetComponent<PaddleController>().playerHP > 0)
            {
                manager.player[1].GetComponent<PaddleController>().playerHP--;
            }
            else
            {
                this.gameObject.GetComponent<Collider>().isTrigger = false;
            }
        }
        if (!isVertical && !isRight)
        {
            if(manager.player[2].GetComponent<PaddleController>().playerHP > 0)
            {
                manager.player[2].GetComponent<PaddleController>().playerHP--;
            }
            else
            {
                this.gameObject.GetComponent<Collider>().isTrigger = false;
            }
        }
        if (!isVertical && isRight)
        {
            if (manager.player[3].GetComponent<PaddleController>().playerHP > 0)
            {
                manager.player[3].GetComponent<PaddleController>().playerHP--;
            }
            else
            {
                this.gameObject.GetComponent<Collider>().isTrigger = false;
            }
        }
    }
}
