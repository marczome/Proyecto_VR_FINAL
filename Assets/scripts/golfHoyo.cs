using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golfHoyo : MonoBehaviour
{
    public ParticleSystem particulas;
    private Vector3 posicionInicialPelota = new Vector3(-5.5f, 0.05f, -1.4f);
    private GameObject pelota;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Golf"))
        {

            particulas.Play();

            
            Destroy(other.gameObject);

            
            GenerarNuevaPelota();
        }
    }

    private void GenerarNuevaPelota()
    {
        if (posicionInicialPelota != null)
        {
            
            pelota = Instantiate(Resources.Load("Golf_ball_2")) as GameObject;
            pelota.transform.position = posicionInicialPelota;
        }
    }
}

