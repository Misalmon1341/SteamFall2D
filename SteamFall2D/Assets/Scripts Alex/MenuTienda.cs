using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuTienda : MonoBehaviour
{
    public void PersonajesJugables()
    {
        SceneManager.LoadScene("PersonajesJugablesScene");
    }
    public void NivelesDesbloqueables()
    {
        SceneManager.LoadScene("NivelesDesbloqueables");
    }
    public void DLC()
    {
        SceneManager.LoadScene("DLC");
    }
    public void Skins()
    {
        SceneManager.LoadScene("Skins");
    }
    public void YearPass()
    {
        SceneManager.LoadScene("YearPass");
    }
    public void OfertasEspeciales()
    {
        SceneManager.LoadScene("OfertasEspeciales");
    }
     void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MenuPrincipal");
        }
    }
}
