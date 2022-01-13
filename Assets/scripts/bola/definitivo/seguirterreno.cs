using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguirterreno : MonoBehaviour {
    private Transform tranformjugador;
	void Start () {
        tranformjugador = GameObject.FindGameObjectWithTag("jugador").transform;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.forward * tranformjugador.position.z;
	}
}
