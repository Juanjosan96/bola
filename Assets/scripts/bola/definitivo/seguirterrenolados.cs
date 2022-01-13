using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguirterrenolados : MonoBehaviour
{
    public Transform transpared;
    public Vector3 posicionpared=new Vector3(-20,0,0);
    public float speed = 100f;
    public GameObject pared;
    public Vector3 velocidad;

    private Transform tranformjugador;

    void Start()
    {
        transpared = GameObject.FindGameObjectWithTag("jugador").transform;
    }

    // Update is called once per frame
    void Update()
    {
        posicionpared = Vector3.forward * transpared.position.z;
    }
}