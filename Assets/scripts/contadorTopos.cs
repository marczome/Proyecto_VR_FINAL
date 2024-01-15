using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contadorTopos : MonoBehaviour
{
    public WhackAMoleManager whackAMoleManager;

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

        whackAMoleManager.IniciarContador();

        yield return new WaitForSeconds(35f);


        whackAMoleManager.DetenerContador();
        whackAMoleManager.ManejarPuntuacion();
        Debug.Log("parar");

        contadorActivo = false;
    }
}
