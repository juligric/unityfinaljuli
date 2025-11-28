using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class caida : MonoBehaviour
{
    public float alturaMinima = -5f;   // Cuando el jugador baja de esta altura -> perder

    void Update()
    {
        if (transform.position.y < alturaMinima)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene("Perdiste");
        }
    }
}

