using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LlaveManagerDetector : MonoBehaviour
{
    public comprobarPuerta comprobarPuerta;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Llave"))
        {
            comprobarPuerta.IncrementarTotalLlaves();
            Destroy(other.gameObject);
        }
    }

}
