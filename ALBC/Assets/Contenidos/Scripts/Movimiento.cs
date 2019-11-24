using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    public GameObject jugador;
    public Rigidbody2D rb2d;

    public float velocidadMaxima;
    public float velocidad;
    public float movimientoH;
    public float potenciaSalto;


    public bool devMode;


    private void Awake()
    {
        jugador = GameObject.Find("Jugador");

        rb2d = jugador.gameObject.GetComponent<Rigidbody2D>();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb2d.AddForce(new Vector2(0f, potenciaSalto));
        }

        Debug.Log(rb2d.velocity.x);
    }

    private void FixedUpdate()
    {

        movimientoH = Input.GetAxisRaw("Horizontal");

        Vector2 movilidad = new Vector2(movimientoH * velocidad, 0f);

        rb2d.AddForce(movilidad);

        rb2d.velocity = new Vector2(Mathf.Clamp(rb2d.velocity.x, -velocidadMaxima, velocidadMaxima), rb2d.velocity.y);



    }



}
