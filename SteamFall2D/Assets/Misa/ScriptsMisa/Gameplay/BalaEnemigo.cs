using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaEnemigo : MonoBehaviour
{
    public int da�o;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out VidaJugador vidajugador))
        {
            vidajugador.TomarDa�o(da�o);
        }
    }
}
