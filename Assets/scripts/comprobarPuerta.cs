using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comprobarPuerta : MonoBehaviour
{
    public abrirPuerta abrirPuerta;
    public LlaveCuenta LlaveCuenta;
    void OnTriggerEnter(Collider other)
    {
        if (LlaveCuenta.totalLlaves == 3)
        {
            StartCoroutine(abrirPuerta.AbrirPuerta());
        }
    }
}
