using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comprobarPuerta : MonoBehaviour
{
    public abrirPuerta abrirPuerta;
    public LlaveCuenta LlaveCuenta;
    void OnTriggerEnter(Collider other)
    {

        StartCoroutine(abrirPuerta.AbrirPuerta());
        if (LlaveCuenta.totalLlaves == 0)
        {
            StartCoroutine(abrirPuerta.AbrirPuerta());
        }
    }
}
