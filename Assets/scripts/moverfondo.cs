using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverfondo : MonoBehaviour {
    private Rigidbody rb;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
       
    }
    // Use this for initialization
    void Start () {
        rb.velocity = new Vector3(paneljuego.instance.velocidadfondo,0,0);
	}
	
	// Update is called once per frame
	void Update () {
        if (paneljuego.instance.gameover)
        {
            rb.velocity = Vector3.zero;
        }

	}
}
