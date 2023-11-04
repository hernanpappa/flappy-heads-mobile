using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_up : MonoBehaviour
{
    public GameObject Levelup;
    public static Level_up level;

    // Start is called before the first frame update
    void Start()
    {
        level = this;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Levelmenu()
    {
        Levelup.SetActive(true);
    }
}
