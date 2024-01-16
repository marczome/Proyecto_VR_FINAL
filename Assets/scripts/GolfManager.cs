using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolfManager : MonoBehaviour
{
    public AudioSource sonido;
    public ParticleSystem particulas;
    private static bool llaveGeneradaGlobal = false;
    public GameObject llavePrefab;

    public void GenerarLlaveP()
    {
        if (!llaveGeneradaGlobal)
        {
            llaveGeneradaGlobal = true;
            Vector3 posicionGeneracion = new Vector3(-15.046f, 0.797f, 2.676795f);
            Instantiate(llavePrefab, posicionGeneracion, Quaternion.identity);
        }

    }
}
