using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhackAMoleManager : MonoBehaviour
{
    public float tiempoSubidaMin = 1f;
    public float tiempoSubidaMax = 4f;
    public float tiempoMantenimientoMin = 1f;
    public float tiempoMantenimientoMax = 4f;
    public WhackAMoleMovimiento whackAMoleMovimiento;
    public WhackAMoleLlave generadorLlave;
    public AudioSource musicaVictoria;
    public AudioSource golpeTopo;
    public AudioSource musicaPerder;

    public float incrementoAltura = 0.2f;

    private bool corutinaActiva = false;
    public GameObject llavePrefab;
    public bool cicloSubir = false;
    private bool llaveGenerada = false;

    public static int puntuacionGlobal = 0;

    public void IniciarContador()
    {
        if (!corutinaActiva)
        {
            cicloSubir = true;
            StartCoroutine(whackAMoleMovimiento.CicloSubirBajar());
            corutinaActiva = true;
        }
    }
    public void DetenerContador()
    {
        if (corutinaActiva)
        {
            cicloSubir = false;
            StopCoroutine(whackAMoleMovimiento.CicloSubirBajar());
            corutinaActiva = false;
            
        }
    }
    public void ManejarPuntuacion()
    {
        if (puntuacionGlobal > 2 && !llaveGenerada)
        {
            musicaVictoria.Play();
            GenerarLlave();
            Debug.Log("Victoria");

        }
        else
        {
            musicaPerder.Play();
            

        }

        puntuacionGlobal = 0;
    }

    private void GenerarLlave()
    {
        llaveGenerada = true;  
        Vector3 posicionGeneracion = new Vector3(-4.128376f, 1.761f, -17.28055f);
        Instantiate(llavePrefab, posicionGeneracion, Quaternion.identity);
        
    }


}
