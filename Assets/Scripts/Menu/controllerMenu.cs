using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class controllerMenu : MonoBehaviour
{
    public Text textOptions;
    public Text textCredits;
    public Text textExit;
    public Text textPlay;

    public Image imageOptions;
    public Image imageCredits;
    public Image imageExit;
    public Image imagePlay;



    public void Play()
    {
        SceneManager.LoadScene("Animação");
    }

    public void onPlay()
    {
        textPlay.fontSize = 58;
        imagePlay.color = new Color32(245, 134, 52, 255);
    }
    public void offPlay()
    {
        textPlay.fontSize = 50;
        imagePlay.color = new Color32(0, 0, 0, 255);
    }

    public void onOptions()
    {
        textOptions.fontSize = 58;
        imageOptions.color = new Color32(245,134,52,255);
    }
    public void offOptions()
    {
        textOptions.fontSize = 50;
        imageOptions.color = new Color32(0, 0, 0, 255);
    }
    public void onCredits()
    {
        textCredits.fontSize = 58;
        imageCredits.color = new Color32(245, 134, 52, 255);
    }
    public void offCredits()
    {
        textCredits.fontSize = 50;
        imageCredits.color = new Color32(0, 0, 0, 255);
    }
    public void onExit()
    {
        textExit.fontSize = 58;
        imageExit.color = new Color32(245, 134, 52, 255);
    }
    public void offExit()
    {
        textExit.fontSize = 50;
        imageExit.color = new Color32(0, 0, 0, 255);
    }
}
