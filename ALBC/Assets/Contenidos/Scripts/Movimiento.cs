using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [Header("Llamados")]

    public GameObject jugador;
    public Rigidbody2D rb2d;

    [Header("Movimiento")]

    public float velocidadMaxima;
    public float velocidad;
    public float movimientoH;

    [Header("Salto")]

    public bool isGrounded;
    public float potenciaSalto;
    public float longitudRayo;
    


    [Header("Developers")]

    public bool devMode;


    private void Awake()
    {

        // AQUÍ BUSCAMOS LOS ELEMENTOS EN LA JERARQUÍA.

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

        // SALTO

        if (Input.GetKeyDown(KeyCode.W))
        {
            rb2d.AddForce(new Vector2(0f, potenciaSalto));
        }


        RaycastHit ground;
        Ray posicionRayo = new Ray(transform.position, Vector3.down);

        if (Physics.Raycast(posicionRayo, out ground, longitudRayo))
        {
            if(ground.collider.tag == "")
            {
                isGrounded = true;
            }
        }

        // VELOCIDAD EN CONSOLA - COMPROBAR LOS LÍMITES
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
