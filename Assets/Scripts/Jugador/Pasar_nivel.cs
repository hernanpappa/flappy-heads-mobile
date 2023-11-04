using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pasar_nivel : MonoBehaviour
{
    public string Tag;
    public GameObject LEVEL_UP;
    public GameObject Player;

    void OnTriggerEnter2D(Collider2D choque)
    {
        if (choque.CompareTag(Tag))
        {
            LEVEL_UP.SetActive(true);
            Player.SetActive(false);

        }
    }
}
