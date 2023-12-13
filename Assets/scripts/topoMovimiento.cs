using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topoMovimiento : MonoBehaviour
{
    public float tiempoSubidaMin = 1f;
    public float tiempoSubidaMax = 10f;
    public float tiempoMantenimientoMin = 1f;
    public float tiempoMantenimientoMax = 5f;
    public float tiempoBajadaMin = 1f;
    public float tiempoBajadaMax = 10f;

    public int puntuacion = 0;

    private bool colisiona = false;

    private void Start()
    {
        // Iniciar el bucle de comportamiento
        StartCoroutine(CicloSubirBajar());
    }

    private System.Collections.IEnumerator CicloSubirBajar()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(tiempoSubidaMin, tiempoSubidaMax));
            SubirObjeto();

            yield return new WaitForSeconds(Random.Range(tiempoMantenimientoMin, tiempoMantenimientoMax));

            if (colisiona)
            {
                BajarObjeto();
                colisiona = false; 
            }
            else
            {
                puntuacion++;
                Debug.Log("Puntuación: " + puntuacion);
            }
        }
    }

    private void SubirObjeto()
    {
        Debug.Log("Subiendo objeto");

    }

    private void BajarObjeto()
    {
        Debug.Log("Bajando objeto");

    }

    private void OnCollisionEnter(Collision collision)
    {
        colisiona = true;
    }

}
