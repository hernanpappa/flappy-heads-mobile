using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public Levitar levitar;
    private Animator animacion;
    public Animator MijagiAnim;
    public Ataque MijaquiAtaque;
    public Detectar_balas Balas;
    public GameObject MijagiCuerpo;
    public int vida;
    public int Velocidad_muerte;
    // Start is called before the first frame update
    void Start()
    {
        animacion = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        vida = Balas.vida;
        animacion.SetFloat("Vida", vida);

        if (vida < 300)
        {
            levitar.maxTime = 6;
            levitar.maxVelocity = 45;
            levitar.velocidad = 500;
            MijaquiAtaque.maxTime = 40;
            MijagiAnim.SetBool("Lanzar", false);
            MijaquiAtaque.Lanzamiento = "Lanzar2";
            MijaquiAtaque.EstadoMijagi = "Mijagi_idle 0";

        }
        if (vida < 200)
        {
            levitar.maxTime = 5;
            levitar.maxVelocity = 60;
            levitar.velocidad = 700;
            MijaquiAtaque.maxTime = 30;
            MijagiAnim.SetBool("Lanzar2", false);
            MijaquiAtaque.Lanzamiento = "Lanzar3";
            MijaquiAtaque.EstadoMijagi = "Mijagi_idle 1";
        }
        if (vida < 120)
        {
            levitar.maxTime = 4;
            levitar.maxVelocity = 75;
            levitar.velocidad = 900;
            MijaquiAtaque.maxTime = 25;
            MijagiAnim.SetBool("Lanzar3", false);
            MijaquiAtaque.Lanzamiento = "Lanzar4";
            MijaquiAtaque.EstadoMijagi = "Mijagi_idle 2";
        }
        if (vida < 50)
        {
            levitar.maxTime = 3;
            levitar.maxVelocity = 110;
            levitar.velocidad = 1100;
            MijaquiAtaque.maxTime = 15;
            MijagiAnim.SetBool("Lanzar4", false);
            MijaquiAtaque.Lanzamiento = "Lanzar5";
            MijaquiAtaque.EstadoMijagi = "Mijagi_idle 3";
        }
        if (vida < 1)
        {
            MijaquiAtaque.enabled = false;
            MijagiAnim.SetBool("Lanzar5", false);
            //MijagiCuerpo.transform.RotateAround(Vector3.back, 50 * Time.deltaTime);
            MijagiCuerpo.transform.Rotate(Vector3.back, Velocidad_muerte * Time.deltaTime);
            levitar.enabled = false;
            
        }

    }
}
