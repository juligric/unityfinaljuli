using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class volver : MonoBehaviour
{
    public void Reiniciar()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Debug.Log("juli");
        SceneManager.LoadScene("proeycto final");
        
    }
}

    