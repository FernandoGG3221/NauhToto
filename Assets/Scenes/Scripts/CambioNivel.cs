using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioNivel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CargaNivel(string pNombreEscena)
    {
        SceneManager.LoadScene(pNombreEscena);
    }

    public void Salir()
    {
        Debug.Log("Saliendo");
        Application.Quit();
        //return;
    }

    public void volverMenu()
    {
        Application.LoadLevel(1);
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                //quit application on return button
                Application.LoadLevel(1);
                return;
            }
        }
    }

    public void VolverJugar()
    {
        Application.LoadLevel(2);
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                //quit application on return button
                Application.LoadLevel(2);
                return;
            }
        }
    }

    public void VolerCategorias()
    {
        Application.LoadLevel(3);
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                //quit application on return button
                Application.LoadLevel(3);
                return;
            }
        }
    }

    public void Volver()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                //quit application on return button
                Application.Quit();
                return;
            }
        }
    }
}
