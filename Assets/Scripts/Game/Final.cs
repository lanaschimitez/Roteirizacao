using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Final : MonoBehaviour
{
    public Text text1;
    public Text text2;
    public string timeText;
    void Start()
    {
        text1.text = "Ficou vivo por:" + UserData.time;
        text2.text = "Ficou vivo por:" + UserData.time;
    }
}
