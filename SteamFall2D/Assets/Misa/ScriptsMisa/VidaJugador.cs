using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJugador : MonoBehaviour
{
  
    public int cantidadVida;
    public void TomarDaño(int daño)
    {
        cantidadVida -= daño;
        if (cantidadVida <= 0)
        {
            Destroy(gameObject);
        }
    }

}

