using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class llavePuerta : MonoBehaviour
{
    public LlaveCuenta LlaveCuenta;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Llave"))
        { // 
            LlaveCuenta.totalLlaves++; // Aumenta la variable totalLlaves
            Destroy(collision.gameObject); // Destruye el objeto llave al ser recogido (puedes ajustar esto según tus necesidades)
            Debug.Log("Llave recogida. Total de llaves: " + LlaveCuenta.totalLlaves);
        }
    }
}

