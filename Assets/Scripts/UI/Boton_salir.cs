using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton_salir : MonoBehaviour
{

    public void salir()
    {
        Application.Quit();
        Debug.Log("Se ah salido del juego");
    }

}
