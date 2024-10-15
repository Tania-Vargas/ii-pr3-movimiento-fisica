using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej7_cubo : MonoBehaviour
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

        if (Input.GetKey(KeyCode.UpArrow)) { moveDirection = Vector3.forward; } 
        else if (Input.GetKey(KeyCode.DownArrow)) { moveDirection = Vector3.back; }
        else if (Input.GetKey(KeyCode.LeftArrow)) { moveDirection = Vector3.left; } 
        else if (Input.GetKey(KeyCode.RightArrow)) { moveDirection = Vector3.right; }

        tr.Translate(moveDirection * speed * Time.deltaTime);
    }
}
