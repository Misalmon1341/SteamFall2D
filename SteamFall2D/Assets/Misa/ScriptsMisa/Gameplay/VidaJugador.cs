using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJugador : MonoBehaviour
{
  
    public int cantidadVida;
    public void TomarDa�o(int da�o)
    {
        cantidadVida -= da�o;
        if (cantidadVida <= 0)
        {
            Destroy(gameObject);
        }
    }

}

