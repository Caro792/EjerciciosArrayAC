using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivadorDeObjetos : MonoBehaviour
{
    public GameObject[] arrayDeObjetos;
    private int currentIndex = 0; 
    private int reverseIndex; 

    void Start()
    {
        
        DesactivarPrimerElemento(arrayDeObjetos);

        
        DesactivarTodosLosElementos(arrayDeObjetos);

       
        reverseIndex = arrayDeObjetos.Length - 1;
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.C))
        {
            DesactivarSiguienteElemento(arrayDeObjetos);
        }

       
        if (Input.GetKeyDown(KeyCode.R))
        {
            DesactivarElementoEnReversa(arrayDeObjetos);
        }
    }

    void DesactivarPrimerElemento(GameObject[] lista)
    {
        if (lista != null && lista.Length > 0 && lista[0] != null)
        {
            lista[0].SetActive(false);
        }
    }

    void DesactivarTodosLosElementos(GameObject[] lista)
    {
        if (lista == null) return;

        foreach (GameObject objeto in lista)
        {
            if (objeto != null)
            {
                objeto.SetActive(false);
            }
        }
    }

    void DesactivarSiguienteElemento(GameObject[] lista)
    {
        if (lista == null || currentIndex >= lista.Length) return;

        if (lista[currentIndex] != null)
        {
            lista[currentIndex].SetActive(false);
        }
        currentIndex++;
    }

    void DesactivarElementoEnReversa(GameObject[] lista)
    {
        if (lista == null || reverseIndex < 0) return;

        if (lista[reverseIndex] != null)
        {
            lista[reverseIndex].SetActive(false);
        }
        reverseIndex--;
    }
}