using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTest : MonoBehaviour
{
    public GameObject player;
    float velocidad = 5f;

    // Move to left
    public void Izquierda()
    {
        player.transform.Translate(-Vector2.right * velocidad * Time.deltaTime);
    }

    // Mover a la derecha
    public void Derecha()
    {
        player.transform.Translate(Vector2.right * velocidad * Time.deltaTime);
    }
}
