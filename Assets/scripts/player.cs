using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 8f;

    void Update()
    {
        // --- Movimiento ---
        float h = Input.GetAxis("Horizontal");
        Vector3 move = new Vector3(h, 0f, 0f) * speed * Time.deltaTime;
        transform.Translate(move);

        // --- Raycast ---
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100f))
        {
            if (hit.collider.CompareTag("Enemy"))
            {
                Debug.Log("Enemigo en la mira: " + hit.collider.name);
            }
        }
    }
}
