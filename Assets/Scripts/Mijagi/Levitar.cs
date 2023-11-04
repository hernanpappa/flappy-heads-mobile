using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levitar : MonoBehaviour
{
    Transform posicion;
    Rigidbody2D cuerpo;
    public int velocidad;
    public int maxVelocity;
    public int maxTime;
    float time = 10;
    bool direccion = true;
    float num;

    void Start()
    {
        cuerpo = GetComponent<Rigidbody2D>();
        posicion = GetComponent<Transform>();
    }


    void Update()
    {
        time -= Time.deltaTime;

        if (time < 0)
        {
            System.Random rand = new System.Random();
            num = rand.Next(0, maxTime);
            time = num;

            if (direccion == true)
            {
                direccion = false;
            }
            else
            {
                direccion = true;
            }

        }
        else
        {


            cuerpo.velocity = new Vector2(cuerpo.velocity.x, 0);
            if (direccion == true)
            {
                cuerpo.AddForce(Vector2.up * velocidad);
            }
            else
            {
                cuerpo.AddForce(Vector2.down * velocidad);
            }

            if (cuerpo.velocity.y > maxVelocity)
            {
                cuerpo.velocity = new Vector2(cuerpo.velocity.x, maxVelocity);
            }
            else
            if (cuerpo.velocity.y < -maxVelocity)
            {
                cuerpo.velocity = new Vector2(cuerpo.velocity.x, -maxVelocity);
            }


        }

        if (posicion.position.y < -9)
        {
            direccion = true;
        }
        else if (posicion.position.y > 11)
        {
            direccion = false;
        }



    }

}
