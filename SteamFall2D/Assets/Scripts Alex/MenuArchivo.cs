using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuArchivo : MonoBehaviour
{
    public void Historia()
    {
        SceneManager.LoadScene("Historia");
    }
    public void Artbook()
    {
        SceneManager.LoadScene("Artbook");
    }
    public void Musica()
    {
        SceneManager.LoadScene("Musica");
    }
    public void Logros()
    {
        SceneManager.LoadScene("Logros");
    }
    public void Enciclopedia()
    {
        SceneManager.LoadScene("Enciclopedia");
    }
    public void DiaroDeGuerra()
    {
        SceneManager.LoadScene("DiarioDeGuerra");
    }
     void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MenuPrincipal");
        }
    }
}
