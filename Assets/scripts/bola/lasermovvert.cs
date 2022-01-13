using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lasermovvert : MonoBehaviour {

    public Vector3 teleportPoint;
    public Rigidbody rb;
    public float velocidad = 5f;
    Vector3 posicion=new Vector3(0,0,0);
    bool final = true;
    private void Start()
    {

        posicion = new Vector3(0, Mathf.Clamp(10, 10, 10), 0);
    }

    void FixedUpdate()
    {
        rb.MovePosition( transform.position +posicion * Time.deltaTime);

    }
}
