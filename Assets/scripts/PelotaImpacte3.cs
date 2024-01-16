using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelotaImpacte3 : MonoBehaviour
{
    public PelotaMaquinaManager PelotaMaquinaManager;
    public ParticleSystem impacto;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("impacto");
        PelotaMaquinaManager.puntuacionGlobalP += 3;
        Debug.Log(PelotaMaquinaManager.puntuacionGlobalP);
        PelotaMaquinaManager.canasta.Play();
        impacto.Play();
    }
}
