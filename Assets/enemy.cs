using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
