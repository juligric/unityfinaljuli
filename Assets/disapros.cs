using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disapros : MonoBehaviour
{
    public GameObject piedraPrefab;
    public Transform spawnPoint;
    public float fuerza = 700f;

    void Update()
    {
        // Dispara una piedra cada vez que pasa cierto tiempo
        if (Time.frameCount % 60 == 0) // cada ~1 segundo
        {
            LanzarPiedra();
        }
    }

    void LanzarPiedra()
    {
        GameObject piedra = Instantiate(piedraPrefab, spawnPoint.position, spawnPoint.rotation);

        Rigidbody rb = piedra.GetComponent<Rigidbody>();

        // IMPORTANTE: AddForce
        rb.AddForce(spawnPoint.forward * fuerza, ForceMode.Impulse);
    }
}
