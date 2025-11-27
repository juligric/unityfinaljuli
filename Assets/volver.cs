using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class volver : MonoBehaviour
{
    void Start()
    {
        // Liberar cursor cuando se carga la escena "Perdiste"
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        // Si el Player siguió vivo entre escenas, lo desactivo
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
            player.SetActive(false);
    }

    public void Reiniciar()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        Debug.Log("Botón apretado");
        SceneManager.LoadScene("intentamos de nuevo");
    }
}
