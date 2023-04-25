using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 10f;  
    public KeyCode jumpKey;  
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();  // Obtener la referencia al Rigidbody de la bola
    }

    void Update()
    {
        if (Input.GetKeyDown(jumpKey))  
        {
            DoJump();  
        }
    }

    void DoJump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);  // Añadir una fuerza vertical a la bola para hacerla saltar
    }
}

