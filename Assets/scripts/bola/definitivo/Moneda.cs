using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour {


	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0, 1);
      
	}
    private void OnEnable()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "jugador")
        {
            gestordefinitivo.instancia.obtenermoneda();
            Destroy(gameObject);
            Debug.Log("choque");
        }
    }
}
