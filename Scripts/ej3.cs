using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej3 : MonoBehaviour
{
    public Vector3 moveDirection;
    public float speed = 2f;
    private Transform tr;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        //if (tr.position.y != 0) {
        //    tr.position = new Vector3(tr.position.x, 0, tr.position.z);
        //} 
    }

    // Update is called once per frame
    void Update()
    {
        // usar translate con eje local
        //<tr.Translate(moveDirection * speed * Time.deltaTime);
        // usar translate con eje mundial
        tr.Translate(moveDirection * speed * Time.deltaTime, Space.World);
    }
}
