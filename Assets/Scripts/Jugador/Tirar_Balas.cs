using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tirar_Balas : MonoBehaviour
{
    public GameObject jugador;
    public GameObject bala;
    Vector2 posicion;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            posicion = new Vector2(-11.5f, jugador.transform.position.y - 1);
            Instantiate(bala, posicion, Quaternion.identity);
        }
    }
}
