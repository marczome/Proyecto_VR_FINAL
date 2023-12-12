using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanastaPuntos : MonoBehaviour
{
    public static int Puntuaci�n = 0;
    public ParticleSystem particulas;

    private void IncrementarPuntuacion()
    {
        Puntuaci�n++;
    }

    void OnTriggerEnter(Collider other)
    {

        if(other.CompareTag("Pelota"))
        {
            Debug.Log("aaaaa");
            IncrementarPuntuacion();
            particulas.Play();
        }
    }
}
