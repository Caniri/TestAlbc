using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{

    [Header("Llamados")]
    public GameObject camara;
    public Transform transformJugador;


    [Header("Offsets")]

    public float offsetY;
    public float offsetZ;

    // Start is called before the first frame update
    void Start()
    {

        camara = GameObject.Find("Camara");

        transformJugador = GameObject.Find("Jugador").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {

        camara.transform.position = new Vector3( transformJugador.position.x, transformJugador.position.y + offsetY, transformJugador.position.z + offsetZ);

    }
}
