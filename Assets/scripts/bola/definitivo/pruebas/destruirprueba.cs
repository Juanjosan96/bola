using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruirprueba : MonoBehaviour
{
    public Transform objetivo;
  
    void Update() {
        float distanciaX = transform.position.x - objetivo.position.x;
        float distanciaY = transform.position.y - objetivo.position.y;
        float distanciaZ = transform.position.z - objetivo.position.z;
      
       // Debug.Log(-distanciaZ);
        if (-distanciaZ >= 20)//la distancia para que se destruya
        {
            Destroy(gameObject);//reciclar
          

        }
    }
}
