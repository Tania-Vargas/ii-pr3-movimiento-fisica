using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCilindro : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento
    private Rigidbody rb;

    void Start()
    {
        // Obtener el componente Rigidbody
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 moveDirection = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.W)) { moveDirection = Vector3.forward; } 
        else if (Input.GetKey(KeyCode.S)) { moveDirection = Vector3.back; }
        else if (Input.GetKey(KeyCode.A)) { moveDirection = Vector3.left; } 
        else if (Input.GetKey(KeyCode.D)) { moveDirection = Vector3.right; }

        // Aplicar la fuerza al Rigidbody
        rb.AddForce(moveDirection * speed);
    }
}