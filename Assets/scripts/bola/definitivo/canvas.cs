using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvas : MonoBehaviour {
    public GameObject ObjetoGeneral;
    public Camera Camara;
    public gestordefinitivo gestor;
   //poner ondeath de gestordef
    private void Update()
    {
        
        if (gestor) //gestordefinitivo
        {
            ObjetoGeneral.SetActive(false);
        }
        else
        {
            ObjetoGeneral.SetActive(true);

        }
    }


}
