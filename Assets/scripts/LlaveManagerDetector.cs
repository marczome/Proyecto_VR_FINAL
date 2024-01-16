using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LlaveManagerDetector : MonoBehaviour
{
    public comprobarPuerta comprobarPuerta;
    public ParticleSystem particulas;
    public AudioSource sonido;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Llave"))
        {
            comprobarPuerta.IncrementarTotalLlaves();
            particulas.Play();
            sonido.Play();
            Destroy(other.gameObject);
        }
    }

}
