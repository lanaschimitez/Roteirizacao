using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float velocidade;
    public float forca;
    Rigidbody playerBody;

    private void Start()
    {
        playerBody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        transform.Translate(velocidade * Time.deltaTime, 0, 0);

        if (Input.GetKeyDown("space"))
        {
            playerBody.AddForce(0, 50*forca, 0);
        }
    }
}
