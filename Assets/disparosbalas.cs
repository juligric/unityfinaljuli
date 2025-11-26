using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparosbalas : MonoBehaviour
{
    public float speed = 500f;    // Fuerza que se aplica
    public float lifetime = 3f;   // Tiempo antes de destruirse

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Empuja la bala hacia adelante desde su rotación
        rb.AddForce(transform.forward * speed);

        // Destruye la bala después de un tiempo
        Destroy(gameObject, lifetime);
    }
}
