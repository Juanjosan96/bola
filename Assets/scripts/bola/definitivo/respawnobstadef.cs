using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnobstadef : MonoBehaviour
{
    public GameObject obstaculo;
    // Start is called before the first frame update
    void Start()
    {for (int i = 0; i < 10; i++)
        {
            Instantiate(obstaculo, transform.position, Quaternion.identity);
        }
        return;
    }

 
}
