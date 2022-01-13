 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum tipospieza
{
    nada = -1,
    laser = 0,
    trampa = 1,
    lasermovimiento = 2,
    monedas=3,
    //si querer añadir mas con su numeracion
}

public class Pieza : MonoBehaviour {
    public tipospieza tipo;
    public int indicevisual;
}
