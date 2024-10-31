using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private Transform zonaDisparo;

    [SerializeField] private GameObject bala;

    public float coolDown;

    bool poderDisparar = true;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H) && poderDisparar)
        {
            Disparar();
        }
    }

    private void Disparar()
    {
        poderDisparar = false;
        Invoke("CoolDown", coolDown);
        Instantiate(bala, zonaDisparo.position, zonaDisparo.rotation);
    }




    private void CoolDown()
    {
        poderDisparar = true;
    }
}
