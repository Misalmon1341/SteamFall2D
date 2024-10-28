using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuDificultad : MonoBehaviour
{
    public Button botonCadete;
    public Button botonSargento;
    public Button botonCapitan;
    public Button botonComandante;
    public Button botonUltimoHombre;
    public Text textoDificultad;

    private string dificultadSeleccionada;
    // Start is called before the first frame update
    void Start()
    {
        dificultadSeleccionada = PlayerPrefs.GetString("Dificultad", "Normal");
        ActualizarTextoDificultad();
        botonCadete.onClick.AddListener(() => SeleccionarDificultad("Cadete"));
        botonSargento.onClick.AddListener(() => SeleccionarDificultad("Sargento"));
        botonCapitan.onClick.AddListener(() => SeleccionarDificultad("Capitan"));
        botonComandante.onClick.AddListener(() => SeleccionarDificultad("Comandante"));
        botonUltimoHombre.onClick.AddListener(() => SeleccionarDificultad("Ultimo Hombre en Pie"));      
    }

    public void SeleccionarDificultad(string dificultad)
    {
        dificultadSeleccionada = dificultad;
        PlayerPrefs.SetString("Dificultad", dificultadSeleccionada);
        PlayerPrefs.Save();
        ActualizarTextoDificultad();
    }

    void ActualizarTextoDificultad()
    {
        switch(dificultadSeleccionada)
        {
            case "Cadete":
                textoDificultad.text = "Dificultad actual: Cadete (Fácil)";
                break;
            case "Sargento":
                textoDificultad.text = "Dificultad actual: Sargento (Normal)";
                break;
            case "Capitan":
                textoDificultad.text = "Dificultad actual: Capitán (Difícil)";
                break;
            case "Comandante":
                textoDificultad.text = "Dificultad actual: Comandante (Muy Difícil)";
                break;
            case "Ultimo Hombre en Pie":
                textoDificultad.text = "Dificultad actual: Último Hombre en Pie (Permadeath)";
                break;
            default:
                textoDificultad.text = "Dificultad actual: Sargento (Normal)";
                break;
        }
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Configuracion");
        }
    }
}
