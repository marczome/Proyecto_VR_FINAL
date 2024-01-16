using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comprobarPuerta : MonoBehaviour
{
    public abrirPuerta abrirPuerta;
    public int totalLlaves;
    public void IncrementarTotalLlaves()
    {
        totalLlaves++;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && totalLlaves == 3)
        {
            StartCoroutine(abrirPuerta.AbrirPuerta());
        }
    }
}
