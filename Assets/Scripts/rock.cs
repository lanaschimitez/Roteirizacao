﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock : MonoBehaviour
{
    public float speed;
    public float x;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = transform.position.x;
        x += speed * Time.deltaTime;

        transform.position = new Vector3(x, transform.position.y, transform.position.z);

        if(x <= -11)
        {
            Destroy(transform.gameObject);
        }
    }
}
