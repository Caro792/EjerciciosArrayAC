using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosArray1 : MonoBehaviour
{
   public GameObject[] objetos;
    private int index = 0;

    void Start()
    {
        // Desactiva todos los objetos al iniciar la escena
        foreach (GameObject obj in objetos) obj.SetActive(false);
    }

    void Update()
    {
        // Activa de a uno al presionar la tecla hasta que queden todos activos
        if (Input.GetKeyDown(KeyCode.Space) && index < objetos.Length)
        {
            objetos[index].SetActive(true);
            index++;
        }
    }
}