using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej5_esfera : MonoBehaviour
{
    public float speed = 2f;
    private Transform tr;


    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
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
    }
}
