using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monederoCuenta : MonoBehaviour
{
    public int totalMonedas = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Moneda"))
        {
            RecolectarMoneda(other.gameObject);
        }
    }

    private void RecolectarMoneda(GameObject moneda)
    {
        totalMonedas++;
        moneda.SetActive(false); //eliminar las monedas
    }
}

