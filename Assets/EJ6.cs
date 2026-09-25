using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ6 : MonoBehaviour
{
public GameObject[] objetos;
    private int index = -1;

    void Start()
    {
        
        foreach (GameObject obj in objetos) obj.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && objetos.Length > 0)
        {
           
            if (index >= 0) objetos[index].SetActive(false); 
            
            
            index = (index + 1) % objetos.Length;           
            
           
            objetos[index].SetActive(true);                  
        }
    }
}