using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LlaveCuenta : MonoBehaviour
{
    public int totalLlaves = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Llave"))
        {
            totalLlaves++;
            Destroy(other.gameObject);

        }
    }
}
