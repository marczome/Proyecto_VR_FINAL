using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contadorTopos : MonoBehaviour
{
    public WhackAMoleManager WhackAMoleManager;

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

        WhackAMoleManager.IniciarContador();

        yield return new WaitForSeconds(35f);


        WhackAMoleManager.DetenerContador();
        
        Debug.Log("parar");

        contadorActivo = false;
    }
}
