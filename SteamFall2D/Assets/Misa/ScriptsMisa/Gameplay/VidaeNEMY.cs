using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaeNEMY : Puntaje
{
    public float cantidadvida;
    public float cantidadPuntos;

    [SerializeField] private Puntaje puntaje;
    public void TomarDa�o(int da�o)
    {
        cantidadvida =- da�o;
        if (cantidadvida <= 0f)
        {
            puntaje.SumarPuntos(cantidadPuntos);
            Destroy(gameObject);
        }
    }

}



