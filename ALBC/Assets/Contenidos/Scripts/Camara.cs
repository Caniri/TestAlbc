using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{

    public GameObject camara;

    public Transform jugador;

    public float margenY;


    // Start is called before the first frame update
    void Start()
    {
        camara = GameObject.Find("Camara");

        jugador = GameObject.Find("Jugador").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        camara.transform.position = new Vector3(jugador.position.x, jugador.position.y + margenY, -10f);
    }
}
