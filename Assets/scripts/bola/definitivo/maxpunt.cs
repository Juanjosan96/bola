
using UnityEngine;
using UnityEngine.UI;
public class maxpunt : MonoBehaviour {

    public Text maxpuntos;
    public Transform jugador;
    void Start()
    {
        gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update () {
        maxpuntos.text = jugador.position.z.ToString("0");
	}
}
