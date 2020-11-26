using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject rock;
    public float timer;
    public float rate;

    private void Start()
    {
        timer = 0;
    }
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= rate)
        {
            timer = 0;
            GameObject tempPrefab = Instantiate(rock) as GameObject;
        }
    }
}