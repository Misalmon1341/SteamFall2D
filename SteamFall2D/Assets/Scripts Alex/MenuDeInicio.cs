using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuDeInicio : MonoBehaviour
{
    public string MenuPrincipal;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(MenuPrincipal);
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();

            /*solo esto sirve para cerrar el juego
            desde el editor misa*/
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #endif
        }
    }
}
