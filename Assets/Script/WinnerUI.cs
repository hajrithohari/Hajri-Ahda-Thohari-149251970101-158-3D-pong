using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinnerUI : MonoBehaviour
{
    public Text winner;

    private void Update()
    {
        winner.text = PlayerPrefs.GetString("winner");
    }
}
