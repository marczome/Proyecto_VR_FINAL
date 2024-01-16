using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelotaImpacto1 : MonoBehaviour
{
    public PelotaMaquinaManager PelotaMaquinaManager;
    public ParticleSystem impacto;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("impacto");
        PelotaMaquinaManager.puntuacionGlobalP++;
        Debug.Log(PelotaMaquinaManager.puntuacionGlobalP);
        PelotaMaquinaManager.canasta.Play();
        impacto.Play();
    }
}
