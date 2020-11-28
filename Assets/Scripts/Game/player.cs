using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float velocidade;
    public float forca;
    bool pulo;
    Rigidbody playerBody;

    private void Start()
    {
        pulo = false;
        playerBody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        transform.Translate(velocidade * Time.deltaTime, 0, 0);

        if (Input.GetKeyDown("space") && pulo == false)
        {
            pulo = true;
            playerBody.AddForce(0, 50 * forca, 0);
            Invoke("PermitePulo", 1f);
        }
    }

    void PermitePulo()
    {
        pulo = false;
    }
}
