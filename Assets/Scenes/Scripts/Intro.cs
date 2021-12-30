using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    float tiempo;

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        if (tiempo>=7.56)
        {
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
            Application.LoadLevel("MenuOpcion2");
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
        }
    }
}
