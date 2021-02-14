using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                //quit application on return button
//#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                Application.LoadLevel(0);
//#pragma warning restore CS0618 // El tipo o el miembro están obsoletos

            }
        }
    }
}
