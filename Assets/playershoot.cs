using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playershoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireRate = 0.25f;
    private float cooldown = 0f;

    void Update()
    {
        cooldown -= Time.deltaTime;

        if (Input.GetKey(KeyCode.Space) && cooldown <= 0f)
        {
            Shoot();
            cooldown = fireRate;
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}