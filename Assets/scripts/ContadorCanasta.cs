using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorCanasta : MonoBehaviour
{
    public PelotaMaquinaManager PelotaMaquinaManager;
    private bool contadorActivo = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!contadorActivo)
            {
                StartCoroutine(ContadorCoroutinaP());
            }
        }
    }

    private IEnumerator ContadorCoroutinaP()
    {
        contadorActivo = true;

        PelotaMaquinaManager.IniciarContadorP();

        yield return new WaitForSeconds(35f);


        PelotaMaquinaManager.DetenerContadorP();

        Debug.Log("parar");

        contadorActivo = false;
    }
}
