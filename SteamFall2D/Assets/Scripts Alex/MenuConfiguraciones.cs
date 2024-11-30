using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuConfiguraciones : MonoBehaviour
{
    public void Controles()
    {
        SceneManager.LoadScene("Controles");
    }
    public void Dificultad()
    {
        SceneManager.LoadScene("Dificultad");
    }
    public void Graficos()
    {
        SceneManager.LoadScene("Graficos");
    }
    public void Audios()
    {
        SceneManager.LoadScene("Audios");
    }
    public void Interfaz()
    {
        SceneManager.LoadScene("Interfaz");
    }
    public void Accesibilidad()
    {
        SceneManager.LoadScene("Accesibilidad");
    }
    public void OpcionesAvanzadas()
    {
        SceneManager.LoadScene("OpcionesAvanzadas");
    }
     void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MenuPrincipal");
        }
    }

}
