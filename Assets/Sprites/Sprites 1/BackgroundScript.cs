using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    public Vector3 initialPos, finalPos;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x - .1f * speed, transform.position.y, transform.position.z);

        if(transform.position.x <= finalPos.x)
        {
            transform.position = initialPos;
        }
    }
}
