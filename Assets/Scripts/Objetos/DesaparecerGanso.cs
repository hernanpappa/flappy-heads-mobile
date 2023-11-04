using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesaparecerGanso : MonoBehaviour
{
    public string Tag;
    public GameObject ganso;

    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == Tag)
        {
            Destroy(ganso);
        }
    }
}
