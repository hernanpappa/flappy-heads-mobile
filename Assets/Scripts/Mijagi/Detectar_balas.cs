using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detectar_balas : MonoBehaviour
{
    public int vida;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bala"))
        {
            vida = vida - 3;
        }
    }
}

