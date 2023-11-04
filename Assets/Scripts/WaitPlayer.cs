using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitPlayer : MonoBehaviour
{
    public GameObject Player;
    public GameObject Objeto;
    public GameObject llegada;
    public GameObject Esto;
    public GameObject musica;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Player.SetActive(true);
            Objeto.SetActive(true);
            llegada.SetActive(true);
            musica.SetActive(true);
            Esto.SetActive(false);
        }
    }
}
