using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float velocidade;
    void Update()
    {
        transform.Translate(velocidade * Time.deltaTime, 0, 0);
    }
}
