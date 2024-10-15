using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej9 : MonoBehaviour
{
    void OnCollisionEnter(Collision colision) {
        GameObject objetoColision = colision.gameObject;
        Debug.Log(objetoColision.tag + " colisiono con el cilindro");
    }
}
