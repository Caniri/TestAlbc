using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{

    [Header("Llamados")]

    public GameObject jugador;
    public Rigidbody rb;


    [Header("Salto")]

    public bool isGounded;
    public float potenciaDeSalto;



    // Start is called before the first frame update
    void Start()
    {


        jugador = GameObject.Find("Jugador");

        rb = jugador.GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {

        // SALTO
        // isGrounded es peusto como "True" o "False" en el script de sombra,
        // Ya que ahí estan los Raycast.


        if(Input.GetButtonDown("Jump") && isGounded == true)
        {
            rb.AddForce(new Vector3(0f, potenciaDeSalto, 0f));
        }

    }
}
