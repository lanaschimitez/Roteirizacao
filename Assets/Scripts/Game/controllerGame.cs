using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controllerGame : MonoBehaviour
{
    public Text textTempo;
    public float gameTimer;

    private void Start()
    {
        gameTimer = 0;
    }
    void Update()
    {
        gameTimer += Time.deltaTime;

        int seconds = (int)(gameTimer % 60);
        int minutes = (int)(gameTimer / 60) % 60;
        PlayerPrefs.SetFloat("time", gameTimer);

        string timerString = string.Format("{0:00}:{1:00}", minutes, seconds);
        textTempo.text = timerString;
        UserData.time = timerString;

    }
}

