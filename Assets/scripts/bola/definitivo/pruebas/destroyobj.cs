using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyobj: MonoBehaviour
{

    //usar el mismo comando de velocidad de jugador, asi la detruccion sera a la par que el jugador sumando unos segundos de margen

    // Use this for initialization
    void Start()
    {

    }

    void OnEnable()
    {
        Invoke("AutoD", 4f);
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void AutoD()
    {
        Destroy(gameObject);
    }
}
