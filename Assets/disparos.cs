using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparos : MonoBehaviour
{
    public GameObject piedraPrefab;
    public Transform puntoDireccion; // Objeto que apunta
    public float fuerza = 15f;       // Más grande = más arco
    public float arco = 1.5f;        // ← controla cuánta curva tiene
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

        // Dirección forward + impulso vertical = arco
        Vector3 direccion = (puntoDireccion.forward + puntoDireccion.up * arco).normalized;

        rb.velocity = direccion * fuerza;  // ← ESTO genera un arco perfecto
    }
}
