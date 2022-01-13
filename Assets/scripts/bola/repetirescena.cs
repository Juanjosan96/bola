using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repetirescena : MonoBehaviour {
    private BoxCollider groundcollider;
    private float groundhorizontal;
    private void Awake()

    {
        groundcollider = GetComponent<BoxCollider>();
    }
    void Start () {
        groundhorizontal = groundcollider.size.x;
	}
    private void reposicionarfondo()
    {
        transform.Translate(Vector3.right * groundhorizontal * 2);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
