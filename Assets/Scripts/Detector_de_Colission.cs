using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector_de_Colission : MonoBehaviour
{
    public float velocidad;

    void update ()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * velocidad * Time.deltaTime);
        }
        
    }

    /*void OnCollissionEnter2D(Collision2D collision)
    {
        Debug.Log("Se ha colissionado xd");
    }*/

    //Se activa cuando el box collider esta puesto en modo is trigger y un objeto con box collider lo toca
    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Se ha Triggeado xd");
    }
}
