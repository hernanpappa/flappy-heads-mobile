using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accion_saltar : MonoBehaviour {

    public float speed;
	public float max_speed;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {

		rb2d = GetComponent<Rigidbody2D>();
		
	}

	void Update(){

        if (Input.anyKey)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb2d.velocity = new Vector2(rb2d.velocity.x, 0);
                rb2d.AddForce(Vector2.up * speed);
                //Debug.Log("SALTA!"); 
            }



            if (rb2d.velocity.y > max_speed)
            {

                rb2d.velocity = new Vector2(rb2d.velocity.x, max_speed);
                //Debug.Log(rb2d.velocity.y);
            }


        }

        if (rb2d.velocity.y < -max_speed)
           {

                rb2d.velocity = new Vector2(rb2d.velocity.x, -max_speed);
                //Debug.Log(rb2d.velocity.y);
            }
    }

}