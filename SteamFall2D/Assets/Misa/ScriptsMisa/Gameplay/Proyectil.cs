using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    [SerializeField] private float velocidad;

    [SerializeField] private int daño;

    [SerializeField] private float tiempoObjeto;

    private void Start()
    {
        Destroy(gameObject, tiempoObjeto);
    }

    private void Update()
    {
        transform.Translate(Vector2.up * velocidad * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out VidaeNEMY vidaEnemigo))
        {
            vidaEnemigo.TomarDaño(daño);
            Destroy(gameObject);
        }
    }
}
