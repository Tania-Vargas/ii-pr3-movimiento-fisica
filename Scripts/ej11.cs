using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej11 : MonoBehaviour
{
    void OnTriggerEnter(Collider colision) {
        GameObject objetoColision = colision.gameObject;
        Debug.Log(objetoColision.tag + " colisiono con el cilindro");
    }
}
