using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comprobar_Salto : MonoBehaviour
{
    
    Animator animator;
    private Rigidbody2D rb2d;
    //KeyCode Salto;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        //Salto = KeyCode.Space;
        
    }

    // Update is called once per frame
    void Update()
    {
        //bool salto = Input.GetButtonDown("Salto");


        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("Salto", true);
        }
        
        if(Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("Salto", false);
        }

    }
}
