using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparos : MonoBehaviour
{
    public GameObject piedraPrefab;
    public Transform puntoDireccion;
    public float fuerza = 15f;
    public float intervalo = 1f;

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= intervalo)
        {
            LanzarPiedra();
            timer = 0f;
        }
    }

    void LanzarPiedra()
    {
        GameObject piedra = Instantiate(piedraPrefab, puntoDireccion.position, Quaternion.identity);
        Rigidbody rb = piedra.GetComponent<Rigidbody>();

        Vector3 direccion = Vector3.up;

        rb.velocity = direccion * fuerza;

        // 🔥 Hace que la piedra desaparezca
        Destroy(piedra, 3f);
    }
}
