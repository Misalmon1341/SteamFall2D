using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bhpatternsa : MonoBehaviour
{
    public int numBulletsPerWave, numArms;
    public float bulletSpeed, bulletsLifeSpan;
    public GameObject bulletPrefab;
   


    public void Start()
    {
        StartCoroutine("ActivePattern");
    }
    // Update is called once per fram

    Vector3 Circle(float s, float radius)
    {
        float x = radius * Mathf.Cos(s * Mathf.PI / 180);
        float y = radius * Mathf.Sin(s * Mathf.PI / 180);
        return new Vector3(x, y, 0);
    }

    Vector3 star(float s, int np)
    {
        float x = (np - 1) * Mathf.Cos(s * Mathf.PI / 180) + Mathf.Cos((np - 1f) * s * Mathf.PI / 180);
        float y = (np - 1) * Mathf.Sin(s * Mathf.PI / 180) + Mathf.Sin((np - 1f) * s * Mathf.PI / 180);
        return new Vector3(x, y, 0);
    }

    Vector3 Spiral(float s, float angleOffset, float curl)
    {
        float x = curl * s * Mathf.Cos((s - angleOffset) * Mathf.PI / 180);
        float y = curl * s * Mathf.Sin((s - angleOffset) * Mathf.PI / 180);
        return new Vector3(x, y, 0);
    }
    void CirclePattern()
    {
        for (int i = 0; i < numBulletsPerWave; i++)
        {
            float s = 360f * i / numBulletsPerWave;
            Vector3 circlePosition = Circle(s, 1f);
            GameObject bullet = Instantiate(bulletPrefab, transform.position + circlePosition, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = bulletSpeed * circlePosition.normalized;
            Destroy(bullet, bulletsLifeSpan);
        }
    }

    void StarPattern()
    {
        for (int i = 0; i < numBulletsPerWave; i++)
        {
            float s = 360f * i / numBulletsPerWave;
            Vector3 starPosition = star(s, 5);
            GameObject bullet = Instantiate(bulletPrefab, transform.position + starPosition, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = bulletSpeed * starPosition.normalized;
            Destroy(bullet, bulletsLifeSpan);
        }
    }

    void SpiralPattern()
    {
        for (int i = 0; i < numBulletsPerWave; i++)
        {
            float s = 360f * i / numBulletsPerWave;
            for (int j = 0; j < numArms; j++)
            {
                Vector3 spiralPosition = Spiral(s, 360f * j / numArms, 0.05f);
                GameObject bullet = Instantiate(bulletPrefab, transform.position + spiralPosition, Quaternion.identity);
                bullet.GetComponent<Rigidbody2D>().velocity = bulletSpeed * spiralPosition.normalized;
                Destroy(bullet, bulletsLifeSpan);
            }
        }

    }

    IEnumerator ActivePattern()
    {
        StarPattern();
        yield return new WaitForSeconds(4);
        SpiralPattern();
        yield return new WaitForSeconds(4);
        CirclePattern();
        yield return new WaitForSeconds(4);
    }
}
