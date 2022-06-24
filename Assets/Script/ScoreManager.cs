using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public bool isVertical;
    public bool isRight;

    public GoalManager manager;

    private void OnTriggerEnter(Collider other)
    {
        Goal();
    }

    public void Goal()
    {
        if (isVertical && isRight)
        {
            if (manager.player[0].GetComponent<PaddleControllerVertical>().playerHP > 0)
            {
                manager.player[0].GetComponent<PaddleControllerVertical>().playerHP--;
            }
            else
            {
                this.gameObject.GetComponent<Collider>().isTrigger = false;
            }
        }
        if (isVertical && !isRight)
        {
            if (manager.player[1].GetComponent<PaddleControllerVertical>().playerHP > 0)
            {
                manager.player[1].GetComponent<PaddleControllerVertical>().playerHP--;
            }
            else
            {
                this.gameObject.GetComponent<Collider>().isTrigger = false;
            }
        }
        if (!isVertical && !isRight)
        {
            if(manager.player[2].GetComponent<PaddleControllerHorizontal>().playerHP > 0)
            {
                manager.player[2].GetComponent<PaddleControllerHorizontal>().playerHP--;
            }
            else
            {
                this.gameObject.GetComponent<Collider>().isTrigger = false;
            }
        }
        if (!isVertical && isRight)
        {
            if (manager.player[3].GetComponent<PaddleControllerHorizontal>().playerHP > 0)
            {
                manager.player[3].GetComponent<PaddleControllerHorizontal>().playerHP--;
            }
            else
            {
                this.gameObject.GetComponent<Collider>().isTrigger = false;
            }
        }
    }
}
