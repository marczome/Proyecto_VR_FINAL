using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abrirPuerta : MonoBehaviour
{
    public Transform puntoDeRotacion;

    public IEnumerator AbrirPuerta()
    {
        Vector3 puntoRotacion = puntoDeRotacion.position;
        Debug.Log('b');
        while (transform.rotation.eulerAngles.y < 90)
        {
            Debug.Log('c');
            transform.RotateAround(puntoRotacion, Vector3.up, 20 * Time.deltaTime);
            yield return null;
        }

    }
}