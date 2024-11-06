using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaeNEMY : Puntaje
{
    public float cantidadvida;
    public float puntaje;

    public void TomarDaño(int daño)
    {
        cantidadvida =- daño;
        if (cantidadvida <= 0f)
        {
            //Puntaje Sumarpuntos(puntaje);
            Destroy(gameObject);
        }
    }

}


