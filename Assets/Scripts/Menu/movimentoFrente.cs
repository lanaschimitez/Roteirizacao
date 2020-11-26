using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoFrente : MonoBehaviour
{
    public float speed;
    void Start()
    {
        speed = 1.8f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
