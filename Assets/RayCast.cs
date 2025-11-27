using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    public float distancia = 0.3f;
    public LayerMask suelo;

    public bool enSuelo;

    void Update()
    {
        enSuelo = Physics.Raycast(transform.position, Vector3.down, distancia, suelo);
    }
}
