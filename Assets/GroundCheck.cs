using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // ← necesario para cambiar de escena

public class GroundCheck : MonoBehaviour
{
    public float distancia = 5f;
    public Camera camara;
    public string nombreEscena = "ganaste"; // ← cambialo

    void Update()
    {
        // Rayo horizontal (90°)
        Vector3 direccion = camara.transform.forward;
        direccion.y = 0;
        direccion.Normalize();

        Ray ray = new Ray(camara.transform.position, direccion);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, distancia))
        {
            if (hit.collider.CompareTag("puerta"))
            {
                Debug.Log("TOCÓ LA PUERTA");

                // Cambiar de escena
                SceneManager.LoadScene("ganaste");
            }
        }
    }

    private void OnDrawGizmos()
    {
        if (camara == null) return;

        Vector3 direccion = camara.transform.forward;
        direccion.y = 0;
        direccion.Normalize();

        Gizmos.color = Color.red;
        Gizmos.DrawLine(camara.transform.position,
                        camara.transform.position + direccion * distancia);
    }
}
