using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelotaMaquinaManager : MonoBehaviour
{
    public AudioSource musicaVictoria;
    public AudioSource musicaPerder;
    public AudioSource canasta;
    private bool corutinaActiva = false;
    public GameObject llavePrefab;
    private static bool llaveGeneradaGlobalP = false;

    public static int puntuacionGlobalP = 0;

    public void IniciarContadorP()
    {
        if (!corutinaActiva)
        {
            Debug.Log("inicio");
            corutinaActiva = true;
        }
    }
    public void DetenerContadorP()
    {
        if (corutinaActiva)
        {
            Debug.Log("final");
            ManejarPuntuacionP();
        }
    }
    public void ManejarPuntuacionP()
    {
        if (puntuacionGlobalP > 2 && !llaveGeneradaGlobalP)
        {
            Debug.Log("victoria");
            GenerarLlaveP();
            musicaVictoria.Play();
        }
        else if (puntuacionGlobalP <= 2)
        {
            Debug.Log("derrota");
            if (!llaveGeneradaGlobalP)
            {
                musicaPerder.Play();
            }
        }
    }

    private void GenerarLlaveP()
    {
        if (!llaveGeneradaGlobalP)
        {
            llaveGeneradaGlobalP = true;
            Vector3 posicionGeneracion = new Vector3(0.21f, 1.761f, 15.51f);
            Instantiate(llavePrefab, posicionGeneracion, Quaternion.identity);
        }

    }

}

