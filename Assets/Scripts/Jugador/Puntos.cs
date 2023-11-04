using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntos : MonoBehaviour
{
    public GameObject marcador;
    public string Tag;
    public int points;

    void Start()
    {
        //marcador = GetComponent<GameObject>();
    }

    void OnTriggerEnter2D(Collider2D choque)
    {
        if (choque.CompareTag(Tag))
        {
            points++;
            marcador.GetComponent<Marcador>().SendMessage("EstablecerPuntos", points);
            Debug.Log(points);
        }
    }
}
