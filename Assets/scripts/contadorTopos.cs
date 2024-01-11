using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contadorTopos : MonoBehaviour
{
    public topoMovimiento scriptTopoMovimiento; // Asigna el script topoMovimiento en el Inspector.

    private bool contadorActivo = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!contadorActivo)
            {
                StartCoroutine(ContadorCoroutine());
            }
        }
    }

    private IEnumerator ContadorCoroutine()
    {
        contadorActivo = true;

        scriptTopoMovimiento.IniciarContador();

        yield return new WaitForSeconds(35f);


        scriptTopoMovimiento.DetenerContador();

        Debug.Log("parar");

        contadorActivo = false;
    }
}
