using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolfDetector : MonoBehaviour
{
    public GolfManager GolfManager;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Golf"))
        {
            GolfManager.sonido.Play();
            GolfManager.particulas.Play();
            GolfManager.GenerarLlaveP();
        }
    }
}
