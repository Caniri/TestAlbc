using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muerte : MonoBehaviour
{

    public GameObject jugador;

    public Transform spawn;

    public Movimiento movimiento;

    public float constanteDeMuerte;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Gris")
        {
            Morir();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.Find("Jugador");
        spawn = GameObject.Find("Spawn").GetComponent<Transform>();
        movimiento = GameObject.Find("Jugador").GetComponent<Movimiento>();
    }

    // Update is called once per frame
    void Update()
    {

        

        if (jugador.transform.position.y < constanteDeMuerte)
        {
            Morir();
        }


        if (Input.GetKeyDown(KeyCode.R) && movimiento.devMode == true)
        {
            Morir();
        }
    }

    public void Morir()
    {
        jugador.transform.position = spawn.position;
    }

}
