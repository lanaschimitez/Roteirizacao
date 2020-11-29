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
        InvokeRepeating("Accelerator", 10.0f, 60.0f);
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

    void Accelerator()
    {
        rate -= 0.3f;
    }
}