    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tubitos : MonoBehaviour
{

    private Transform rb2d;
    public float speed;
   
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Transform>();
    }

    // Update is called once per frame



    void FixedUpdate()
    {
      
       rb2d.Translate(speed, 0, 0);
       
    }

}
