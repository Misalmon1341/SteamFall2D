using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuAudio : MonoBehaviour
{
    public Slider sliderVolumenGeneral;
    public Slider sliderMusica;
    public Slider sliderEfectos;
    public GameObject panelPresetAudio;
    public Text textoDispositivo;
    void Start()
    {
        panelPresetAudio.SetActive(false);
        textoDispositivo.text = PlayerPrefs.GetString("DispositivoAudio", "Audífonos");
        sliderVolumenGeneral.value = PlayerPrefs.GetFloat("VolumenGeneral", 100);
        sliderMusica.value = PlayerPrefs.GetFloat("VolumenMusica", 100);
        sliderEfectos.value = PlayerPrefs.GetFloat("VolumenEfectos", 100);
    }

    public void AjustarVolumenGeneral(float valor)
    {
        PlayerPrefs.SetFloat("VolumenGeneral", valor);
        PlayerPrefs.Save();
        AudioListener.volume = valor / 100;
    }

    public void AjustarMusica(float valor)
    {
        PlayerPrefs.SetFloat("VolumenMusica", valor);
        PlayerPrefs.Save();
    }

    public void AjustarEfectos(float valor)
    {
        PlayerPrefs.SetFloat("VolumenEfectos", valor);
        PlayerPrefs.Save();
    }

    public void MostrarPanelPreset()
    {
        panelPresetAudio.SetActive(!panelPresetAudio.activeSelf);
    }

    public void SeleccionarAudifonos()
    {
        PlayerPrefs.SetString("DispositivoAudio", "Audífonos");
        PlayerPrefs.Save();
        textoDispositivo.text = "Audífonos";
    }

    public void SeleccionarBocinas()
    {
        PlayerPrefs.SetString("DispositivoAudio", "Bocinas de Audio");
        PlayerPrefs.Save();
        textoDispositivo.text = "Bocinas de Audio";
    }

    public void SeleccionarBluetooth()
    {
        PlayerPrefs.SetString("DispositivoAudio", "Bocina Bluetooth");
        PlayerPrefs.Save();
        textoDispositivo.text = "Bocina Bluetooth";
    }

    void Update()
    {
        if (panelPresetAudio.activeSelf && Input.GetKeyDown(KeyCode.Escape))
        {
            panelPresetAudio.SetActive(false);
        }

        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Configuracion");
        }
    }
}
