using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void AbrirTienda()
    {
        SceneManager.LoadScene("MenuTienda");
    }
    public void ReanudarJuego()
    {
        SceneManager.LoadScene("Reanudar");
    }
    public void SeleccionNivel()
    {
        SceneManager.LoadScene("SeleccionNivel");
    }
    public void AbrirArchivo()
    {
        SceneManager.LoadScene("Archivo");
    }
    public void AbrirConfiguracion()
    {
        SceneManager.LoadScene("Configuracion");
    }
     void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MenuDeInicio");
        }
       
    }
}
