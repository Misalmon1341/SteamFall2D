using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaeNEMY : Puntaje
{
    public float cantidadvida;
    public float puntaje;

    public void TomarDa�o(int da�o)
    {
        cantidadvida =- da�o;
        if (cantidadvida <= 0f)
        {
            //Puntaje Sumarpuntos(puntaje);
            Destroy(gameObject);
        }
    }

}


