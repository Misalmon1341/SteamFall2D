using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{
    public float force = -3f;
    public float drag = 6f;
    public float lowSpeed = 0.3f;


    private void Awake()
    {
        GetComponent<Rigidbody2D>().drag = drag;
    }
    void Update()
    {
        Movement();

        /*if (Input.GetKey(KeyCode.Space))
        {
           force = lowSpeed;
        }*/
    }

    public void Movement()
    {
        GetComponent<Rigidbody2D>().drag = drag;
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");
        Vector2 direction = new Vector2(hInput, vInput).normalized;
        Vector2 forceVector = force * direction;
        GetComponent<Rigidbody2D>().AddForce(forceVector, ForceMode2D.Force);
    }



    public void Shoot()
    {

    }
}
