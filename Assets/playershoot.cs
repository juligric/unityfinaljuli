using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class playershoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;

    void Update()
    {
        // SOLO dispara cuando apretás la tecla (una vez)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
