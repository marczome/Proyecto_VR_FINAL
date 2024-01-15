using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LlaveDetector : MonoBehaviour
{
    LlaveManager LlaveManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Llave"))
        {
            LlaveManager.IncrementoLlave();
            Destroy(other.gameObject);
        }
    }
}

