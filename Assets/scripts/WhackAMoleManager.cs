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

    public float incrementoAltura = 0.5f;

    private bool corutinaActiva = false;
    public bool cicloSubir = false;

    public int puntuacion = 0;

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
    private void ManejarPuntuacion()
    {
        if (puntuacion < 10)
        {
            // Dar llave
            // Activar música de victoria
            
        }
        else
        {
            // Música de perder
            
        }

        puntuacion = 0;
    }

    

}
