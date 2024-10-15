using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej1 : MonoBehaviour
{

    public float velocidad = 10f;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"),
              vertical = Input.GetAxis("Vertical");
        
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Debug.Log("Flecha arriba: " + (velocidad * vertical));
        } 
        else if(Input.GetKeyDown(KeyCode.DownArrow)) {
            Debug.Log("Flecha abajo: " + (velocidad * vertical));
        } 
        else if(Input.GetKeyDown(KeyCode.LeftArrow)) {
            Debug.Log("Flecha izquierda: " + (velocidad * horizontal));
        } 
        else if(Input.GetKeyDown(KeyCode.RightArrow)) {
            Debug.Log("Flecha derecha: " + (velocidad * horizontal));
        }
    }
}
