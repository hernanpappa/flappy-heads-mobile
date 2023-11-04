using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Escena : MonoBehaviour
{   
    
    public void cambiarescena(int num_escena)
    {
        SceneManager.LoadScene(num_escena);
    }

    //Esto es la forma antigua de cambiar de escena
    /*
    public void cambiarescena(string nombredeescena)
	{
        Application.LoadLevel(nombredeescena);

        
    }*/

}
