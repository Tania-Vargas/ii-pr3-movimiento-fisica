using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej8_cubo : MonoBehaviour
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
        float horizontal = Input.GetAxis("Horizontal");

        tr.Rotate(0, horizontal * 100f * Time.deltaTime, 0);
        tr.Translate(tr.forward * speed * Time.deltaTime, Space.World);
    }
}
