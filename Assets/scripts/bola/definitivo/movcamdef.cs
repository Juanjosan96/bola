using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movcamdef : MonoBehaviour {

    public Transform mirar;
    public Vector3 compensar = new Vector3(0, 0f, 0f);
    private void Start()
    {
        transform.position = mirar.position + compensar;
    }
    private void LateUpdate()
    {
        Vector3 posiciontomada = mirar.position + compensar;
        posiciontomada.x = -5;
        transform.position = Vector3.Lerp(transform.position, posiciontomada,Time.deltaTime);
    }

}
