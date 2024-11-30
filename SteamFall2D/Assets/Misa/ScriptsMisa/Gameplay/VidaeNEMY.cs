using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaeNEMY : Puntaje
{
    public float cantidadvida;
    public float cantidadPuntos;

    [SerializeField] private Puntaje puntaje;
    public void TomarDaño(int daño)
    {
        cantidadvida =- daño;
        if (cantidadvida <= 0f)
        {
            puntaje.SumarPuntos(cantidadPuntos);
            Destroy(gameObject);
        }
    }

}



