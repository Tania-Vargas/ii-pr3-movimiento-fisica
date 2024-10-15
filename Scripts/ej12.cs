using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej12 : MonoBehaviour
{
    public float speed = 2f; // Velocidad de movimiento
    private Rigidbody rb, rbEsfera;

    void Start()
    {
        // Obtener el componente Rigidbody
        rb = GetComponent<Rigidbody>();
        GameObject esfera = GameObject.FindWithTag("esfera");
        rbEsfera = esfera.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 moveDirection = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.I)) { moveDirection = Vector3.forward; } 
        else if (Input.GetKey(KeyCode.K)) { moveDirection = Vector3.back; }
        else if (Input.GetKey(KeyCode.J)) { moveDirection = Vector3.left; } 
        else if (Input.GetKey(KeyCode.L)) { moveDirection = Vector3.right; }
        else if (Input.GetKey(KeyCode.U)) {
            moveDirection = rbEsfera.position - rb.position;
            moveDirection = Vector3.Normalize(moveDirection);
            // Para rotarlo antes de moverlo
            Quaternion rotacion = Quaternion.LookRotation(moveDirection);
            rb.MoveRotation(rotacion);
        }

        // Aplicar la fuerza al Rigidbody
        rb.AddForce(moveDirection * speed);
    }
}
