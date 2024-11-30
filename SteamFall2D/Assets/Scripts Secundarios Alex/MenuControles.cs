using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuControles : MonoBehaviour
{
    public Slider sliderVibracion;
    public Slider sliderSensibilidadMovimiento;
    public Button botonInvertirEjes;
    private bool ejesInvertidos;
    void Start()
    {
        sliderVibracion.value = PlayerPrefs.GetFloat("Vibracion",0.5f);
        sliderSensibilidadMovimiento.value = PlayerPrefs.GetFloat("Sensibilidad", 0.5f);
        ejesInvertidos = PlayerPrefs.GetInt("InvertirEjes", 0) == 1;
        ActualizarTextoBotonInvertirEjes();
    }

    public void AjustarVibracion()
    {
        PlayerPrefs.SetFloat("Vibracion", sliderVibracion.value);
    }

    public void AjustarSensibilidad()
    {
        PlayerPrefs.GetFloat("Sensibilidad", sliderSensibilidadMovimiento.value);
    }

    public void InvertirEjes()
    {
        ejesInvertidos = !ejesInvertidos;
        PlayerPrefs.SetInt("InvertirEjes", ejesInvertidos ? 1 : 0);
        ActualizarTextoBotonInvertirEjes();
    }

    void ActualizarTextoBotonInvertirEjes()
    {
        string texto = ejesInvertidos ? "Ejes Invertidos" : "Ejes Normales";
        botonInvertirEjes.GetComponentInChildren<Text>().text = texto;
    }

    public void RestablecerConfiguracion()
    {
        PlayerPrefs.DeleteAll();
        sliderVibracion.value = 0.5f;
        sliderSensibilidadMovimiento.value = 0.5f;
        ejesInvertidos = false;
        ActualizarTextoBotonInvertirEjes();
    }
    public void GuardarConfiguraciones()
    {
        PlayerPrefs.SetFloat("Vibracion", sliderVibracion.value);
        PlayerPrefs.SetFloat("Sensibilidad", sliderSensibilidadMovimiento.value);
        PlayerPrefs.Save();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            GuardarConfiguraciones();
            SceneManager.LoadScene("Configuracion");
        }
    }
}
