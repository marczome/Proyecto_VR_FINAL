using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class topoMovimiento : MonoBehaviour
{
    public float tiempoSubidaMin = 1f;
    public float tiempoSubidaMax = 4f;
    public float tiempoMantenimientoMin = 1f;
    public float tiempoMantenimientoMax = 4f;

    public float incrementoAltura = 0.5f;
    private float alturainicial;

    public int puntuacion = 0;

    private bool colisiona = false;
    private bool corutinaActiva = false;
    private bool cicloSubir = false;

    void OnCollisionEnter(Collision collision)
    {
        colisiona = true;
       
    }

    private void Start()
    {
        alturainicial = transform.position.y;
    //StartCoroutine(CicloSubirBajar());
    }

    public void IniciarContador()
    {
        if (!corutinaActiva)
        {
            cicloSubir = true;
            StartCoroutine(CicloSubirBajar());
            corutinaActiva = true;
        }
    }

    public void DetenerContador()
    {
        if (corutinaActiva)
        {
            cicloSubir = false;
            StopCoroutine(CicloSubirBajar());
            Debug.Log("parar");
            BajarObjeto();
            corutinaActiva = false;
            if (puntuacion < 10)
            {
                //dar llave
                //activar música victoria
                puntuacion = 0;
            }
            else
            {
                //muscia perder
                puntuacion = 0;
            }

        }
    }
    private void SubirObjeto()
    {
        transform.position = new Vector3(transform.position.x, alturainicial + incrementoAltura, transform.position.z);
        Debug.Log("Subiendo objeto");
    }

    private void BajarObjeto()
    {
        transform.position = new Vector3(transform.position.x, alturainicial, transform.position.z);
        Debug.Log("Bajando objeto");
    }

    private IEnumerator CicloSubirBajar()
    {
        while (cicloSubir)
        {
            yield return new WaitForSeconds(Random.Range(tiempoSubidaMin, tiempoSubidaMax));
            SubirObjeto();

            if (colisiona)
            {
                BajarObjeto();
                colisiona = false;
                puntuacion++;
                Debug.Log("Puntuación: " + puntuacion);
            }
            else
            {
                yield return new WaitForSeconds(Random.Range(tiempoMantenimientoMin, tiempoMantenimientoMax));
                BajarObjeto();
            }
        }
    }
}







