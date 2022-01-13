using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pruebapagina : MonoBehaviour
{
    public float Speed = 6.0f;
    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;
    void Start()
    {
        moveDirection = transform.forward;
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= Speed;
    }
}