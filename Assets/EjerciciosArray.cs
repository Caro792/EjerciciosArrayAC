using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ejercicio5 : MonoBehaviour
{
    public GameObject[] objetos;
    private int index = 0;

    void Start()
    {
        foreach (GameObject obj in objetos) obj.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && index < objetos.Length)
        {
            objetos[index].SetActive(true);
            index++;
        }
    }
}