using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funciones : MonoBehaviour {

    public string comenzar_txt = "El juego comenzo";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void comenzar()
    {
        Debug.Log(comenzar_txt);
    }
}
