using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    [Header("Llamados")]

    public GameObject jugador;
    public Rigidbody rb;


    [Header("Movimiento")]

    public float movimientoH;
    public float movimientoV;
    


    [Header("Velocidades")]

    public float velocidad;
    public float velocidadMáxima;



    // Start is called before the first frame update
    void Start()
    {


        jugador = GameObject.Find("Jugador");

        rb = jugador.GetComponent<Rigidbody>();



    }

    // Update is called once per frame
    void Update()
    {

        movimientoH = Input.GetAxisRaw("Horizontal");

        movimientoV = Input.GetAxisRaw("Vertical");


        Vector3 movimiento = new Vector3(movimientoH * velocidad, 0f, movimientoV * velocidad);

        rb.AddForce(movimiento);


        rb.velocity = new Vector3(Mathf.Clamp(rb.velocity.x, -velocidadMáxima, velocidadMáxima), rb.velocity.y, Mathf.Clamp(rb.velocity.z, -velocidadMáxima, velocidadMáxima));

    }
}
