using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhackAMoleMovimiento : MonoBehaviour
{
    public WhackAMoleManager WhackAMoleManager;
    private float alturainicial;

    private bool colisiona = false;

    private void Start()
    {
        alturainicial = transform.position.y;
    }

    void OnCollisionEnter(Collision collision)
    {
        colisiona = true;
    }

    private void SubirObjeto()
    {
        transform.position = new Vector3(transform.position.x, alturainicial + WhackAMoleManager.incrementoAltura, transform.position.z);
        Debug.Log("Subiendo objeto");
    }

    private void BajarObjeto()
    {
        transform.position = new Vector3(transform.position.x, alturainicial, transform.position.z);
        Debug.Log("Bajando objeto");

        if (colisiona)
        {
            Debug.Log("colision");
            colisiona = false;
            WhackAMoleManager.puntuacion++;

        }
    }

    public IEnumerator CicloSubirBajar()
    {
        while (WhackAMoleManager.cicloSubir)
        {
            yield return new WaitForSeconds(Random.Range(WhackAMoleManager.tiempoSubidaMin, WhackAMoleManager.tiempoSubidaMax));
            SubirObjeto();
            yield return new WaitForSeconds(Random.Range(WhackAMoleManager.tiempoMantenimientoMin, WhackAMoleManager.tiempoMantenimientoMax));
            BajarObjeto();
        }
    }
}
