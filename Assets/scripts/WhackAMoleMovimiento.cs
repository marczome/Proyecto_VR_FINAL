using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhackAMoleMovimiento : MonoBehaviour
{
    public WhackAMoleManager WhackAMoleManager;
    private float alturainicial;
    private bool interrupcionPendiente = false;

    private void Start()
    {
        alturainicial = transform.position.y;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (!interrupcionPendiente)
        {
            BajarObjetoInstantaneamente();
            interrupcionPendiente = true;
        }
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

        
        interrupcionPendiente = false;
    }

    private void BajarObjetoInstantaneamente()
    {
        transform.position = new Vector3(transform.position.x, alturainicial, transform.position.z);
        WhackAMoleManager.puntuacionGlobal++;
        WhackAMoleManager.golpeTopo.Play();
        Debug.Log(WhackAMoleManager.puntuacionGlobal);
    }

    public IEnumerator CicloSubirBajar()
    {
        while (WhackAMoleManager.cicloSubir)
        {
            yield return new WaitForSeconds(Random.Range(WhackAMoleManager.tiempoSubidaMin, WhackAMoleManager.tiempoSubidaMax));

            // Verificar si hay una interrupción pendiente
            if (!interrupcionPendiente)
            {
                SubirObjeto();
                yield return new WaitForSeconds(Random.Range(WhackAMoleManager.tiempoMantenimientoMin, WhackAMoleManager.tiempoMantenimientoMax));
                BajarObjeto();
            }
        }
    }
}


