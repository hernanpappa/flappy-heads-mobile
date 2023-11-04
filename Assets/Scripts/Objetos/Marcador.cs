using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Marcador : MonoBehaviour
{
    //public GameObject marcador;
    public Text texto;
    public int Points;
    

    void Start()
    {
        //marcador = GetComponent<Text>();
        //texto = GetComponent<Text>(marcador);
        Points = 0;
    }

    void Update()
    { 
        texto.text = Points.ToString();
    }

    public void EstablecerPuntos(int value)
    {
        Points = value;
    }
}
