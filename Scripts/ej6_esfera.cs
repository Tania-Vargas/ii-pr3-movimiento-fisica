using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej6_esfera : MonoBehaviour
{
    public float speed = 2f;
    private Transform tr;
    private Transform trCubo;

    // Start is called before the first frame update
    void Start()
    {
        GameObject cubo = GameObject.FindWithTag("cubo");

        tr = GetComponent<Transform>();
        trCubo = cubo.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.W)) { moveDirection = Vector3.forward; } 
        else if (Input.GetKey(KeyCode.S)) { moveDirection = Vector3.back; }
        else if (Input.GetKey(KeyCode.A)) { moveDirection = Vector3.left; } 
        else if (Input.GetKey(KeyCode.D)) { moveDirection = Vector3.right; }

        tr.Translate(moveDirection * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) {
            Vector3 distancia = tr.position - trCubo.position;
            distancia[1] = 0;
            distancia = Vector3.Normalize(distancia);
            trCubo.Translate(distancia * speed * Time.deltaTime);
        }
    }
}
