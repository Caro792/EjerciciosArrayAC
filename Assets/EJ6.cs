using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ6 : MonoBehaviour
{
public GameObject[] objetos;
    private int index = -1;

    void Start()
    {
        // Desactiva todos los objetos al iniciar la escena
        foreach (GameObject obj in objetos) obj.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && objetos.Length > 0)
        {
            // Apaga el elemento actual para que haya solo uno activo a la vez
            if (index >= 0) objetos[index].SetActive(false); 
            
            // Avanza de posicion y reinicia al principio al llegar al final
            index = (index + 1) % objetos.Length;           
            
            // Activa el nuevo elemento
            objetos[index].SetActive(true);                  
        }
    }
}