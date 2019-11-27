using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptSombra : MonoBehaviour
{

    [Header("Llamados")]

    public GameObject jugador;
    public GameObject s;
    public Rigidbody rb;
    public Salto saltoS;

    [Header("Funciones del Raycast isGrounded")]

    public float offsetRayY;
    public float longitudDelRaycast;

    // Start is called before the first frame update
    void Start()
    {

        jugador = GameObject.Find("Jugador");

        s = GameObject.Find("S");

        rb = jugador.GetComponent<Rigidbody>();

        saltoS = jugador.GetComponent<Salto>();


    }

    // Update is called once per frame
    void Update()
    {

        // SOMBRA EN LA POSICIÓN DEL JUGADOR

        s.transform.position = jugador.transform.position;


        // RAYCAST --> GROUNDED

        RaycastHit deteccionInf;

        if (Physics.Raycast(transform.position, -transform.up, out deteccionInf, longitudDelRaycast))
        {
            saltoS.isGounded = true;
        } else
        {
            saltoS.isGounded = false;
        }

	}
}
