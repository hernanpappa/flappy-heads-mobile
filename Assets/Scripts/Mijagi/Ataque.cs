using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque : MonoBehaviour
{
    Animator animador;
    public GameObject ganso;
    public GameObject mijagi;
    public int maxTime;
    float time = 8.1f;
    float num;
    public string Lanzamiento = "Lanzar";
    public string EstadoMijagi = "Mijagi_idle";
    Vector2 posicion;

    void Start()
    {
        animador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


        time -= Time.deltaTime;
        AnimatorStateInfo info = animador.GetNextAnimatorStateInfo(0);

        if (time < 0)
        {

            System.Random rand = new System.Random();
            num = rand.Next(0, maxTime);
            time = Map(num, 0, maxTime, 0, maxTime / 10);
            animador.SetBool(Lanzamiento, true);
        }

        else if (info.IsName(EstadoMijagi) == true)
        {
            animador.SetBool(Lanzamiento, false);
        }

    }

    void Lanzar()
    {
        posicion = new Vector2(16, mijagi.transform.position.y);
        Instantiate(ganso, posicion, Quaternion.identity);
    }
    static public float Map(float value, float istart, float istop, float ostart, float ostop)
    {
        return ostart + (ostop - ostart) * ((value - istart) / (istop - istart));
    }
}
