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

    public Image imageOptions;
    public Image imageCredits;
    public Image imageExit;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void Play()
    {
        SceneManager.LoadScene("Animação");
    }
    public void onOptions()
    {
        textOptions.fontSize = 38;
        imageOptions.color = new Color32(245,134,52,255);
    }
    public void offOptions()
    {
        textOptions.fontSize = 32;
        imageOptions.color = new Color32(0, 0, 0, 255);
    }
    public void onCredits()
    {
        textCredits.fontSize = 38;
        imageCredits.color = new Color32(245, 134, 52, 255);
    }
    public void offCredits()
    {
        textCredits.fontSize = 32;
        imageCredits.color = new Color32(0, 0, 0, 255);
    }
    public void onExit()
    {
        textExit.fontSize = 38;
        imageExit.color = new Color32(245, 134, 52, 255);
    }
    public void offExit()
    {
        textExit.fontSize = 32;
        imageExit.color = new Color32(0, 0, 0, 255);
    }
}
