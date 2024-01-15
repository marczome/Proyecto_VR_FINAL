using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhackAMoleLlave : MonoBehaviour
{
    public GameObject llavePrefab;  

    public void GenerarLlave()
    {
        Vector3 posicionGeneracion = new Vector3(-4.128376f, 1.761f, -17.28055f);
        Instantiate(llavePrefab, posicionGeneracion, Quaternion.identity);
    }
}

