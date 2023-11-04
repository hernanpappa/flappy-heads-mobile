using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comprobar_muerte : MonoBehaviour
{
    Animator animator;
    Accion_saltar salto;
    Rigidbody2D rb2d;
    public float brinco;
    public float max_speed;
    public string Tag;
    bool muerte;
    

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        salto = GetComponent<Accion_saltar>();
        rb2d = GetComponent<Rigidbody2D>();
        muerte = false;
    }
    
 
    void OnTriggerEnter2D(Collider2D choque)
    {
        if(muerte == false)
        {
            if (choque.CompareTag(Tag))
            {
                animator.SetBool("Muerte", true);
            

                rb2d.velocity = new Vector2(rb2d.velocity.x, 0);
                rb2d.AddForce(Vector2.up * brinco);

                if (rb2d.velocity.y > max_speed)
                {
                    rb2d.velocity = new Vector2(rb2d.velocity.x, max_speed);
                    //Debug.Log(rb2d.velocity.y);
                }

                salto.enabled = false;
                muerte = true;

                //gameObject.SetActive(false); Deshabilita al ayer
                GameOverManager.gameOverManager.CallGameOver();
                
            }
        }
        //Debug.Log(choque);

    }

}
