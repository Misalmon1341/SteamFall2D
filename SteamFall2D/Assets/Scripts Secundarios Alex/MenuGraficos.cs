using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

using UnityEngine.SceneManagement;

public class MenuGraficos : MonoBehaviour
{
    public GameObject panelResolucion;
    public GameObject panelTasaFotogramas;
    public Slider sliderBrillo;
    public Button botonAntiAliasing;
    public Button botonParticulas;
    public Slider sliderSaturacion;
    public Text textoAntiAliasing;
    public Text textoParticulas;
    
    private bool antiAliasingActivado;
    private bool particulasActivadas;

    void Start()
    {
        antiAliasingActivado = PlayerPrefs.GetInt("AntiAliasing", 1) == 1;
        particulasActivadas = PlayerPrefs.GetInt("Particulas", 1) == 1;
        sliderBrillo.value = PlayerPrefs.GetFloat("Brillo", 1.0f);
        sliderSaturacion.value = PlayerPrefs.GetFloat("Saturacion", 1.0f);
        
        ActualizarTextoAntiAliasing();
        ActualizarTextoParticulas();
    }

    public void MostrarPanelResolucion()
    {
        panelResolucion.SetActive(true);
    }

    public void MostrarPanelTasaFotogramas()
    {
        panelTasaFotogramas.SetActive(true);
    }

    public void AlternarAntiAliasing()
    {
        antiAliasingActivado = !antiAliasingActivado;
        PlayerPrefs.SetInt("AntiAliasing", antiAliasingActivado ? 1 : 0);
        PlayerPrefs.Save();
        QualitySettings.antiAliasing = antiAliasingActivado ? 4 : 0;
        ActualizarTextoAntiAliasing();
    }
    void ActualizarTextoAntiAliasing()
    {
        textoAntiAliasing.text = antiAliasingActivado ? "Activado" : "Desactivado";
    }

    public void AlternarParticulas()
    {
        particulasActivadas = !particulasActivadas;
        PlayerPrefs.SetInt("Particulas", particulasActivadas ? 1 : 0);
        ActualizarTextoParticulas();
        PlayerPrefs.Save();
    }

    void ActualizarTextoParticulas()
    {
        textoParticulas.text = particulasActivadas ? "Activado" : "Desactivado";
    }

    public void SetResolution1080p()
{
    Screen.SetResolution(1920, 1080, Screen.fullScreen);
    PlayerPrefs.SetInt("Resolucion", 1080);
    PlayerPrefs.Save();
}

public void SetFrameRate60()
{
    Application.targetFrameRate = 60;
    PlayerPrefs.SetInt("FrameRate", 60);
    PlayerPrefs.Save();
}

public void CambiarBrillo(float valor)
{
    PlayerPrefs.SetFloat("Brillo", valor);
    PlayerPrefs.Save();
}
public void CambiarSaturacion(float valor)
{
    PlayerPrefs.SetFloat("Saturacion", valor);
    PlayerPrefs.Save();
}
public void RestablecerConfiguraciones()
{
    PlayerPrefs.DeleteAll();
    PlayerPrefs.Save();
    Screen.SetResolution(1920, 1080, true);
    Application.targetFrameRate = 60;
    QualitySettings.antiAliasing = 4;
    Start();
}

    void Update()
    {
        if (panelResolucion.activeSelf && Input.GetKeyDown(KeyCode.Escape))
    {
        panelResolucion.SetActive(false);
        PlayerPrefs.Save();
        SceneManager.LoadScene("Graficos");
    }

        else if (panelTasaFotogramas.activeSelf && Input.GetKeyDown(KeyCode.Escape))
        {
            panelTasaFotogramas.SetActive(false);
            PlayerPrefs.Save();
            SceneManager.LoadScene("Graficos");

        }

        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            GuardarConfiguraciones();
            SceneManager.LoadScene("Configuracion");
        }
    }

    void GuardarConfiguraciones()
    {
        PlayerPrefs.Save();
    }

}
